using System;

namespace CashCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------This Is Cash Counter In Bank Queue Problem-------------");
            BankingCashCounter<string> BC1 = new BankingCashCounter<string>();
            BC1.CashCounter();
        }
    }
}
