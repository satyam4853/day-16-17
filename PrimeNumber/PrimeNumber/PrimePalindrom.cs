using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumber
{
     public class PrimePalindrom :CheckPrimenumber
    {

        public void check()
        {
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("The prime numbers are : " + i + "\n");
                        break;
                    }

                }







                int  r, sum = 0, temp;
               
                
                temp = i;
                while (i > 0)
                {
                    r = i % 10;
                    sum = (sum * 10) + r;
                    i = i / 10;
                }
                if (temp == sum)
                    Console.Write("Number is Palindrome." +i);
                else
                    Console.Write("Number is not Palindrome" +i);
            }

        } 

    }
}
