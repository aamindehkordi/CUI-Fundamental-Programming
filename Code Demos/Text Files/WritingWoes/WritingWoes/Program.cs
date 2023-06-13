using System;
using System.IO;

namespace WritingWoes
{
    class Program
    {
        public static string ReadFile(string fileName)
        {
            int count = 0;
            string fileData = String.Empty;
            StreamReader sr = new StreamReader(fileName);
            for (int i = 0; !sr.EndOfStream; i++)
            {
                string line = sr.ReadLine();
                fileData += line + ",";
                count++;
            }
            sr.Close();
            return fileData;

        }
        static void Main(string[] args)
        {
            double mass = 0;

            string formula = "HNa2O";

            string elements = "";
            double numberOf = 0;
            int x = 0;
            for (int i = 0; i < formula.Length; i++)
            {
                int j = i + 1;
                if (formula[i] >= 'A' && formula[i] <= 'Z')
                {
                    while (j < formula.Length && formula[j] >= 'a' && formula[j] <= 'z')
                    {
                        j++;
                    }
                    string element = formula.Substring(i, j - i);
                    elements += element + ":"; x++;

                    i = j;
                    while (j < formula.Length && formula[j] >= '0' && formula[j] <= '9')
                    {
                        j++;
                    }
                    if (j != i)
                    { numberOf = double.Parse(formula.Substring(i, j - i)); }
                    if (j == 1)
                    { numberOf = 1; }
                    elements += numberOf + ", "; x++;

                    i--;
                }
                //Console.WriteLine(elements);
            }
            string periodicTable = ReadFile("periodic table.txt");

            int maxSplits = 2000;
            char[] separators = { ':', ',', ' ' };
            string[] ptParts = periodicTable.Split(separators, maxSplits, StringSplitOptions.RemoveEmptyEntries);

            //for(int i = 0; i < ptParts.Length;i++)
            {
                //Console.WriteLine(ptParts[i]);
            }

            string[] eParts = elements.Split(separators, x);

            //eParts[eParts.Length - 1].Remove(eParts.Length - 1, 1);
            int eLast = eParts.Length - 1;
            
            //for (int i = 0; i < eParts.Length-1; i++)
            {
                //Console.Write(eParts[i]+" ");
            }

            string result = String.Empty;
            
            for (int z = 0; z < eParts.Length; z += 2)
            {
            
                string searchTerm = eParts[z];
                int refIndex = periodicTable.IndexOf(searchTerm);
                if (refIndex < 0)
                {
                    Console.WriteLine("Error: Text not found"); return;
                }

                result = periodicTable.Substring(refIndex, searchTerm.Length + 22);
                double tmpMass = 0;
                for (int i = 0; i < result.Length; i++)
                {
                    int j = i + 1;
                    if (result[i] >= '0' && result[i] <= '9')
                    {
                        while (j < result.Length && result[j] >= '0' && result[j] <= '9' || result[j] == '.')
                        {
                            j++;
                        }
                        tmpMass = double.Parse(result.Substring(i, j - i));//
                    }
                    for (int y = 1; y < eParts.Length; y += 1)
                    {

                    }
                }

            }





            /*
            string line1 = "When we were utterly helpless, Christ came at just the right time and died for us sinners.";
            string line2 = "Now, most people would not be willing to die for an upright person, though someone might perhaps be willing to die for a person who is especially good.";
            string line3 = "But God showed his great love for us by sending Christ to die for us while we were still sinners.";

            bool append = false;
            StreamWriter sw = new StreamWriter("Romans5_8.txt", append);
            Console.WriteLine("StreamWriter has been opened");
            Console.WriteLine("Check and then press <ENTER> to continue");
            Console.ReadKey();

            sw.WriteLine(line1);
            sw.WriteLine(line2);
            sw.WriteLine(line3);
            Console.WriteLine("\nLines have been written");
            Console.WriteLine("Check and then press <ENTER> to continue");
            Console.ReadKey();

            sw.Close();
            Console.WriteLine("\nStreamWriter has been closed");
            */
        }
    }
}
