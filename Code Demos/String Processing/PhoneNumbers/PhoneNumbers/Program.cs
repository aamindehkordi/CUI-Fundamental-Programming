using System;

namespace PhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = {
                "(909) 867-5309", "949-214-3286", "9492143295", "949 214-876"
            };

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                phoneNumbers[i] = phoneNumbers[i].Replace("(", "").Replace(")", "");
                phoneNumbers[i] = phoneNumbers[i].Replace("-", "");
                phoneNumbers[i] = phoneNumbers[i].Replace(" ", "");
            }


            Console.WriteLine("Concordia Phone Numbers:");
            foreach (string phoneNumber in phoneNumbers)
            {
                                              // if we don't check length, we risk
                if (phoneNumber.Length == 10) // bounds errors when using Substring()
                {
                    string areaCode = phoneNumber.Substring(0, 3);
                    string prefix = phoneNumber.Substring(3, 3);
                    string lineNumber = phoneNumber.Substring(6, 4);
                    string formatted = $"({areaCode}) {prefix}-{lineNumber}";

                    if (areaCode == "949" && prefix == "214")
                    {
                        Console.WriteLine($"  {formatted}");
                    }
                }
            }
        }
    }
}
