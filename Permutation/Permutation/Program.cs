using System;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Permutation Problem");
            Console.WriteLine("Enter a string to permute : ");
            string str = Console.ReadLine();
            int start = 0, end = str.Length - 1;
            Permutation.PermuteRecursive(str, start, end);
        }
    }
}
