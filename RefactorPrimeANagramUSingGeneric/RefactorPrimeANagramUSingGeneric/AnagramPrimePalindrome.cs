﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorPrimeANagramUSingGeneric
{
    public class AnagramPrimePalindrome
    {
        public static List<int> palindromeList = new List<int>();
        public void CheckPrimeAnagramAndPalindrome()
        {
            List<int> primeList = PrimeRange.FindPrime();
            //PrimeWithinRange.Print(primeList);
            Random rand = new Random();
            int num1 = primeList[rand.Next(1, primeList.Count - 1)];
            int num2 = primeList[rand.Next(1, primeList.Count - 1)];
            string AnagramRes = Anagram.FindAnagram(num1.ToString(), num2.ToString());
            Console.WriteLine(AnagramRes);
            AnagramPrimePalindrome palindrome = new AnagramPrimePalindrome();

            foreach (int i in primeList)
            {
                palindrome.CheckPalindrome(i);
            }
            Console.WriteLine("Prime Numbers that are palindrome are");
            PrimeRange.Print(palindromeList);
        }

        public void CheckPalindrome(int num)
        {
            int temp = num;
            int rev = 0, t;
            while (num > 0)
            {
                t = num % 10;
                rev = (rev * 10) + t;
                num = num / 10;
            }
            if (rev == temp)
            {
                palindromeList.Add(rev);
            }
        }
    }
}
