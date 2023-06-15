using System;
using System.IO;

namespace MadScientist
{
    /// <summary>
    /// A class that calculates the molar mass of a chemical formula.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculates the molar mass of a chemical formula.
        /// </summary>
        /// <param name="formula">The chemical formula to calculate the molar mass of.</param>
        /// <param name="formulaName">The name of the chemical formula (optional).</param>
        /// <returns>The molar mass of the chemical formula.</returns>
        public static double MadChemist(string formula, string formulaName = "")
        {
            double mass = 0; // initialize the molar mass to 0
            string elements = ""; // initialize the elements string to an empty string
            string counter = ""; // initialize the counter string to an empty string
            double numberOf = 0; // initialize the number of atoms to 0
            int x = 0; // initialize the counter to 0

            for (int i = 0; i < formula.Length; i++) // loop through each character in the formula
            {
                int j = i + 1; // set j to the next character
                if (formula[i] >= 'A' && formula[i] <= 'Z') // if the character is an uppercase letter
                {
                    while (j < formula.Length && formula[j] >= 'a' && formula[j] <= 'z') // loop through the lowercase letters that follow
                    {
                        j++;
                    }
                    string element = formula.Substring(i, j - i); // extract the element name
                    elements += element + ":"; // add the element name to the elements string and append a colon
                    x++;

                    i = j; // set i to the next character
                    while (j < formula.Length && formula[j] >= '0' && formula[j] <= '9') // loop through the digits that follow
                    {
                        j++;
                    }
                    if (j != i)
                    { numberOf = double.Parse(formula.Substring(i, j - i)); } // extract the number of atoms
                    else
                        numberOf = 1; // if no number is given, assume there is one atom
                    counter += numberOf + ":"; // add the number of atoms to the counter string and append a colon
                    x++;

                    i--; // set i back to the last character of the element name
                }
            }

            char[] separators = { ':', ',' };
            string[] ptParts = File.ReadAllLines("periodic table.txt"); // read the periodic table from a file
            string[] eParts = elements.TrimEnd(separators).Split(separators); // split the elements string into an array
            string[] cParts = counter.TrimEnd(separators).Split(separators); // split the counter string into an array

            for (int i = 0; i < eParts.Length; i++) // loop through each element in the elements array
            {
                string searchTerm = eParts[i];
                double count = double.Parse(cParts[i]);
                foreach (string atom in ptParts) // loop through each line in the periodic table
                {
                    string[] parts = atom.Split(separators);
                    string symbol = parts[0];
                    double weight = double.Parse(parts[2]);

                    if (symbol == eParts[i]) // if the symbol matches the element name
                    {
                        mass += double.Parse(cParts[i]) * weight; // add the molar mass of the element to the total molar mass
                        break; // exit the loop
                    }
                }
            }
            return mass; // return the total molar mass
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter a chemical formula(CASe mAtTErs: )");
            string formula = Console.ReadLine(); // read the chemical formula from the console
            double mass = MadChemist(formula); // calculate the molar mass of the chemical formula
            Console.WriteLine(mass + "g/mol"); // print the molar mass to the console

        }
    }
}