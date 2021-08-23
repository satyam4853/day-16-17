using System;

namespace PrimeNumber
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Console.WriteLine("This is Prime Number Problem");
            CheckPrimenumber prime = new CheckPrimenumber();
            //prime.Check();
            CheckPrimenumber p1 = new PrimePalindrom();
            p1.Check();
            
        }
    }
}
