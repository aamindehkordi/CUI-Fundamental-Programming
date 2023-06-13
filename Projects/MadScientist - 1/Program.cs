using System;
using System.IO;

namespace MadScientist
{
    class Program
    {
        public static double MadChemist(string formula, string formulaName = "")
        {
            double mass = 0;
            string elements = "";
            string counter = "";
            double numberOf = 0;
            int x = 0;

            for (int i = 0; i < formula.Length; i++) // breaks the formula given apart into separate parts
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
                    else
                        numberOf = 1;
                    counter += numberOf + ":"; 
                    x++;

                    i--;
                }
            }

            char[] separators = { ':', ',' };
            string[] ptParts = File.ReadAllLines("periodic table.txt");//           periodic table array
            string[] eParts = elements.TrimEnd(separators).Split(separators);//     separate elements array
            string[] cParts = counter.TrimEnd(separators).Split(separators);//      counter array

            for (int i = 0; i < eParts.Length; i++) // searches the periodic table for the specific elements in the elements array
            {
                string searchTerm = eParts[i];
                double count = double.Parse(cParts[i]);
                foreach (string atom in ptParts)
                {
                    string[] parts = atom.Split(separators);
                    string symbol = parts[0];
                    double weight = double.Parse(parts[2]);

                    if (symbol == eParts[i])
                    {
                        mass += double.Parse(cParts[i]) * weight;
                        break;
                    }
                }
            }
            return mass;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter a chemical formula(CASe mAtTErs: )");
            string formula = Console.ReadLine();
            double mass = MadChemist(formula);
            Console.WriteLine(mass + "g/mol");

        }
    }
}
