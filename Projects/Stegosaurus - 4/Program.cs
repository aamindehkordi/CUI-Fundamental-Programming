using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stegosaurus
{
    class BinaryDataParser
    {
        public static ushort GetWord(byte[] contents, int offset)
        {
            ushort data = 0;
            ushort temp = 0;

            temp = contents[offset + 0];
            data = (ushort)(data | temp);

            temp = contents[offset + 1];
            temp = (ushort)(temp << 8);
            data = (ushort)(data | temp);



            return data;
        }
        public static uint GetDWord(byte[] contents, int offset)
        {
            uint data = 0;
            uint temp = 0;

            temp = temp | contents[offset + 0];//same as below, just a different way
            data = data | temp;

            temp = contents[offset + 1];
            temp = temp << 8;
            data = data | temp;

            temp = contents[offset + 2];
            temp = temp << 16;
            data = data | temp;

            temp = contents[offset + 3];
            temp = temp << 24;
            data = data | temp;

            return data;
        }
    }

    class BitmapHeader
    {
        public ushort signature;
        public uint imageSize;
        public ushort res1;
        public ushort res2;
        public uint offset;
        public const int headerSize = 14;

        public BitmapHeader(byte[] contents)
        {
            signature = BinaryDataParser.GetWord(contents, 0);
            imageSize = BinaryDataParser.GetDWord(contents, 2);
            res1 = BinaryDataParser.GetWord(contents, 6);
            res2 = BinaryDataParser.GetWord(contents, 8);
            offset = BinaryDataParser.GetWord(contents, 10);

        }

    }

    class BitmapInfoHeader
    {
        public uint internalHeaderSize;
        public int imageWidth;
        public int imageHeight;
        public ushort colorPlanes;
        public ushort colorDepth;
        public uint compression;
        public uint imageDataSize;
        public int horzRes;
        public int vertRes;
        public int colorsInPalette;
        public int importantColors;
        public const int headerSize = 40;

        public BitmapInfoHeader(byte[] contents)
        {

            internalHeaderSize = BinaryDataParser.GetDWord(contents, 14);
            imageWidth = (int)(BinaryDataParser.GetDWord(contents, 18));
            imageHeight = (int)(BinaryDataParser.GetDWord(contents, 22));
            colorPlanes = BinaryDataParser.GetWord(contents, 26);
            colorDepth = BinaryDataParser.GetWord(contents, 28);
            compression = BinaryDataParser.GetDWord(contents, 30);
            imageDataSize = BinaryDataParser.GetDWord(contents, 34);
            horzRes = (int)(BinaryDataParser.GetDWord(contents, 38));
            vertRes = (int)(BinaryDataParser.GetDWord(contents, 42));
            colorsInPalette = (int)(BinaryDataParser.GetDWord(contents, 46));
            importantColors = (int)(BinaryDataParser.GetDWord(contents, 50));
        }
    }

    class Stegosaurus
    {
        byte[] contents;
        BitmapHeader hdr;
        BitmapInfoHeader bih;
        int bytesRemaining;
        int messagePointer;
        string srcFile;
        string dstFile;

        public Stegosaurus()
        {
            return;
        }

        public void ReadBitmap(string fileName)
        {
            srcFile = fileName;
            contents = File.ReadAllBytes(fileName);
            /*Console.WriteLine($"{(char)contents[0]}(Hex: {contents[0]:x}), {(char)contents[1]:x}({contents[1]:x})");*/

            hdr = new BitmapHeader(contents);
            /*Console.WriteLine($"{hdr.imageSize} ({hdr.imageSize:x})");*/

            bih = new BitmapInfoHeader(contents);
            /*Console.WriteLine($"{bih.imageWidth} ({bih.imageWidth:x})");*/
            
            bytesRemaining = bih.imageHeight * bih.imageWidth * 3;
            messagePointer = 0 + BitmapHeader.headerSize + BitmapInfoHeader.headerSize;
        }

        public string ExtractSecretMessage()
        {
            string message = "";
            byte data;

            byte[] output = new byte[bytesRemaining / 8];

            byte result = 0xFF;
            int counter = 0;
            while (bytesRemaining > 0 && result != 0)
            {
                result = 0;
                for (int em = 0; em < 8; em++)
                {
                    data = (byte)(contents[messagePointer + em] & (0b00000001));
                    result = (byte)(result | (data << (7 - em)));
                    output[counter] = result;
                    bytesRemaining--;
                }
                counter++;
                messagePointer += 8;
            }
            byte[] final = new byte[counter];
            for(int i = 0; i < final.Length; i++)
            {
                final[i] = output[i];
            }

            return Encoding.UTF8.GetString(final);
        }

        public bool InsertSecretMessage(string utf16Secret)
        {
            
            byte[] utf8secret = Encoding.UTF8.GetBytes(utf16Secret);
            byte[] terminated = new byte[utf16Secret.Length + 1];
            utf8secret.CopyTo(terminated, 0);
            terminated[terminated.Length - 1] = 0;
            utf8secret = terminated;

            if (utf8secret.Length * 8 > bytesRemaining)
            {
                Console.WriteLine($"Cannot store  {utf8secret.Length} letters, there are only {bytesRemaining} bytes left.");
                return false;
            }

            bytesRemaining = bytesRemaining - utf8secret.Length * 8;

            byte lsBit;
            byte pixel;

            for(int msgCounter = 0; msgCounter < utf8secret.Length; msgCounter++)
            {
                for(int shiftCount = 7; shiftCount >= 0; shiftCount--)
                {
                    pixel = contents[messagePointer];                                         // pull a single byte out
                    lsBit = (byte)((utf8secret[msgCounter] >> shiftCount) & 0x01);            // modify that byte
                    if(lsBit == 0)
                    {
                        pixel = (byte)(pixel & 0xFE);                        
                    }
                    else
                    {
                        pixel = (byte)(pixel | 0x01);
                    }
                    contents[messagePointer] = pixel;                                         // put the byte back in
                    messagePointer++;
                }
            }

            return true;
        }

        public void WriteBitmap(string fileName, bool overwrite=false)
        {
            dstFile = fileName;
            if (srcFile == dstFile && overwrite == false)
            {

                Console.WriteLine("Are you sure you want to overwrite? [Y/N]:");
                String choice = Console.ReadLine();
                if (String.Compare(choice, "Y", true) == 0)
                {
                    File.WriteAllBytes(fileName, contents);
                }
            }
            else
            {
                File.WriteAllBytes(fileName, contents);
            }
            return;
        }
          
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stegosaurus stegFile = new Stegosaurus();
            if ( args.Length == 1)
            {
                stegFile.ReadBitmap(args[0]);
                string secret = stegFile.ExtractSecretMessage();
                Console.WriteLine($"The secret message is: {secret}");
                return;
            }
            if (args.Length == 2)
            {
                stegFile.ReadBitmap(args[0]);
                stegFile.InsertSecretMessage(args[1]);
                stegFile.WriteBitmap($"secret_{args[0]}");
                return;

            }
            if (args.Length == 3)
            {
                stegFile.ReadBitmap(args[0]);
                stegFile.InsertSecretMessage(args[1]);
                stegFile.WriteBitmap(args[2]);
                return;

            }
            else if(args.Length > 3)
            {
                Console.WriteLine("so you're with the soviets eh?");
                /*Console.WriteLine("stegosaurus.exe <fileName> <message> <newFileName>");*/
                return;
            }

            
            
            
            stegFile.WriteBitmap("image1_secret.bmp");

            Stegosaurus secretFile = new Stegosaurus();
            secretFile.ReadBitmap("image1_secret.bmp");
            
            
        }
    }
}
