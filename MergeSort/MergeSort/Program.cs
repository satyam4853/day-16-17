using System;

namespace MergeSort123
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            string [] numbers = { "satyam", "anil", "shubham", "rajesh", "Dipesh", "Akash", "Rani", "Aditya", "40" };
            int len = 9;

            Console.WriteLine("MergeSort By Recursive Method");
            MergeSortExample.MergeSort_Recursive(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);

            

        }
    }
}
