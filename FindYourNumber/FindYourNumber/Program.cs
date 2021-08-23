using System;

namespace FindYourNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------This is Find Your Number Problem---------");
            CheckNumber checknumber = new CheckNumber();
            checknumber.GuessANumber();
        }
    }
}
