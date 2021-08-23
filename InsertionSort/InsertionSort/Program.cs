using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is InsertionSorting ");
            String[] arr = { "Satyam ", "Anil", "Sourabh", "Rahul" };
            InsertionSorting s1 = new InsertionSorting();
            s1.ReadInput();
            s1.Insertion(arr , 10);
         

        }
    }
}
