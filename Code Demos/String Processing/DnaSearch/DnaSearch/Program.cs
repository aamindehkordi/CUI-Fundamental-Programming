using System;

namespace DnaSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna =
                "ctttagctcgaaggtcattaaatgttcaagggcggtttccgagactattctgagaccgta" +
                "tgacttccgagcctttgctggtaaggctcaacgtaagctttaaactgctcgcggtcgcta" +
                "gagaaattagtggtcaatcgaccggtttgttctcttagcatttagatcgggctggtcacc" +
                "atctactaggcaattcatagtaaaagcgaggttagacttgcctttagatcaaaccgctct" +
                "gtataaagggagcgtgccgattgtatcagcggctcattagagattagcgcagtctgaata" +
                "aggtcatgcgatccagagaacaccaagcgccgactgacgaagcactctagtcagaaacac" +
                "gatgcacggcgataatatgaacagttatcgaatgcctcccggctttaagtgtaaccctac" +
                "cgaggcagaatcccgtagccccactcggcgagtgacagggttcatcgctaggtacatact" +
                "aagatgtagtgctttacgcaatctggatgcagccccttacaatctggaacaatgggctca" +
                "accgcggtcaggggcgtcgtgcctgttgggcccttggtacgagatacgaaagctactacc" +
                "caactaaaaagggcttaggtggtgtgagaccggagagggcctcgatattatctcgcgttg" +
                "ctgctcctcgctggagtctagactgctccggccatgggagtccgttagctaaaccaaccg" +
                "tcgcagcgggcaaatagcctagtacaagtcattaccttgtcgcatgtccggtacatcgga" +
                "tgcctaggttgaggcgggccaccgcggagcgaagcgagccacccggggaaaactgtgagc" +
                "gctctccgaaagacttcacccacccccagcattagacgcgattaccatgaaagggtcgat" +
                "attaaataacagcacgcacccacctagtgtctcggctcaggggcattcgtactgcaatgt" +
                "atagaggtttcttttacatgagggcggtagctcacgtagagtctgtagtacgaacctagg";

            int longestCount = 1;
            int longestIndex = 0;
            char longestChar = dna[0];

            int i = 0, j = 1;
            while(j < dna.Length)
            {
                while (j < dna.Length && dna[i] == dna[j]) { j++; }

                int sequenceCount = j - i;
                if (sequenceCount > longestCount)
                {
                    longestCount = sequenceCount;
                    longestIndex = i;
                    longestChar = dna[i];
                }

                i = j;
                j = i + 1;
            }

            Console.WriteLine($"The longest repeating sequence is located at base: {longestIndex} ({longestCount} {longestChar}'s)");
            Console.WriteLine($"{dna.Substring(longestIndex, longestCount)}");
        }
    }
}
