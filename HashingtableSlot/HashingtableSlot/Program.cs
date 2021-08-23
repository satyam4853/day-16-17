using System;

namespace HashingtableSlot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------This Is Hashing Slot Problem----------");
            HashingSlots<string> hashtable = new HashingSlots<string>();
            hashtable.CheckNumber();
        }
    }
}
