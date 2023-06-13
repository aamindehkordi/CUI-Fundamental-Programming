using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        // These are parallel arrays, so the indices line up
        // The first letter represents the first morse code symbol
        // Second letter represents the second morse code symbol
        // ...
        static char[] morseAlphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',', '?', ' '
        };

        static string[] morseCode =
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---",".--.", "--.-", ".-.", "...", "-", "..-",
            "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-",
            ".....", "-....", "--...", "---..", "----.", "-----", ".-.-.-", "--..--",
            "..--..", "       "
        };

        static string message = "Fuzzy wuzzy was a bear. Fuzzy wuzzy had no hair.";

        static string EnglishToMorse(char english)
        {
            // morseCode and morseAlphabet are parallel arrays

            // Step through the entire English alphabet table looking for a matching letter
            for (int i = 0; i < morseAlphabet.Length; i++)
            {
                if (english == morseAlphabet[i])
                {
                    // Now that we have an english letter match, we use the same index
                    // to look up the corresponding morse code symbol
                    return morseCode[i];
                }
            }

            return string.Empty; // error condition if we cannot find a matching letter
        }

        static char MorseToEnglish(string morse)
        {
            // morseCode and morseAlphabet are parallel arrays

            // Step through the entire morse code table looking for a matching symbol
            for (int i = 0; i < morseCode.Length; i++)
            {
                if (morse == morseCode[i])
                {
                    // Now that we have a morse code match, we use the same index
                    // to look up the corresponding english letter 
                    return morseAlphabet[i];
                }
            }

            return '#'; // error condition if we cannot find a matching morse code symbol
        }


        static void Main(string[] args)
        {
            // Translate the English message to an array of Morse Code Symbols
            string[] morse = new string[message.Length];
            for (int i = 0; i < morse.Length; i++)
            {
                morse[i] = EnglishToMorse(message[i]);
            }

            // We can print an array by stepping through it and printing each element
            // individually, or, since they are all strings, we can use the Join() method
            string codedMessage = string.Join(" ", morse);
            Console.WriteLine(codedMessage);
            Console.WriteLine();



            // Right now the spaces between the letters and words are both spaces
            // so we need to replace the word breaks with a special symbol
            string received = codedMessage.Replace("         ", " | ");

            // Divide the morse code string into individual symbols
            string[] parsed = received.Split(' ');
            char[] translated = new char[parsed.Length];

            for (int i = 0; i < translated.Length; i++)
            {
                translated[i] = MorseToEnglish(parsed[i]);
            }

            Console.WriteLine(new string(translated));
        }
    }
}
