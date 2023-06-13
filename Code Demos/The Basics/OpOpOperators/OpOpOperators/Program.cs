using System;


namespace OpOpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof(decimal) == " + sizeof(decimal));
            Console.WriteLine("sizeof(double)  == " + sizeof(double));
            Console.WriteLine("sizeof(float)   == " + sizeof(float));

            float divisionTest1 = 5 / 2; // this is zero because division is an integer operation... try making the 5 a float and it works
            Console.WriteLine($"\nfloat 5/2   = {divisionTest1}");
            float divisionTest2 = 5F / 2F;
            Console.WriteLine($"float 5F/2F = {divisionTest2}");
            int divisionTest3 = 5 / 2;
            int remainderTest = 5 % 2;
            Console.WriteLine($"int 5/2     = {divisionTest3} remainder {remainderTest}");

            int orderOfOperations1 = 5 + 2 * 2;
            Console.WriteLine("\n5 + 2 * 2   = " + orderOfOperations1);
            int orderOfOperations2 = (5 + 2) * 2;
            Console.WriteLine("(5 + 2) * 2 = " + orderOfOperations2);

            int orderOfOperations3 = 4 / 2 * 6;
            Console.WriteLine("\n4 / 2 * 6   = " + orderOfOperations3);
            int orderOfOperations4 = 4 / (2 * 6);
            Console.WriteLine("4 / (2 * 6) = " + orderOfOperations4 + "\n");

            Console.WriteLine($"5 < 2 is {5 < 2}");
            Console.WriteLine($"'CUI' == 'CUI' is {"CUI" == "CUI"}");
            Console.WriteLine($"'CUI' != 'BIOLA' is {"CUI" != "BIOLA"}");
            Console.WriteLine($"'CUI' == 'CUI' || 'CUI' == 'BIOLA' is {"CUI" == "CUI" || "CUI" == "BIOLA"}\n");
            //Console.WriteLine($"'Aaron < Aardvark is {"Aaron" < "Aardvark"}"); // this won't compile... can't do > < with strings

            int test = 0;
            Console.WriteLine($"0++ = {test++} or {test}");
            Console.WriteLine($"++1 = {++test}\n");

            string stringTest = "Mr. Joshua" + ' ';
            stringTest = stringTest + "Tallman";
            Console.WriteLine(stringTest);

            //stringTest = stringTest - "Mr. "; // compile error: cannot use minus operator on strings
            //stringTest.Remove(0, 4);
            //stringTest = stringTest.Remove(0, 4);
            Console.WriteLine(stringTest);
        }
    }
}
