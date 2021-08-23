using System;
using System.Collections.Generic;

namespace RefactorPrimeANagramUSingGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------This is Prime range Using Generic-------");
            Anagram.StringAnagram();
            List<int> list = PrimeRange.FindPrime();
            PrimeRange.Print(list);
            AnagramPrimePalindrome anagramAndPalindrome = new AnagramPrimePalindrome();
            anagramAndPalindrome.CheckPrimeAnagramAndPalindrome();
        }
    }
}
