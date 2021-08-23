using System;
using System.Collections.Generic;
using System.Text;

namespace Permutation
{
   public  class Permutation
    {
        public static void PermuteRecursive(string str, int startPos, int endPos)
        {
            if (startPos == endPos)
                Console.WriteLine(str);
            else
            {
                for (int i = startPos; i <= endPos; i++)
                {
                    str = Swap(str, 0, i);
                    PermuteRecursive(str, startPos + 1, endPos);
                    str = Swap(str, startPos, i);
                }
            }
        }
        public static String Swap(String str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }


}

