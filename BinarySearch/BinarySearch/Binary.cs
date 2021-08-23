using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
   public class Binary
    {
        public static int binarySearch(String[] arr, String x)
        {
            int num = 0, r = arr.Length - 1;
            while (num <= r)
            {
                int m = num + (r - num) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid
                if (res == 0)
                    return m;

                // If x greater, ignore left half
                if (res > 0)
                    num = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            return -num;
        }

    }

}

