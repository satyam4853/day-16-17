using System;

namespace QueueUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------This is Queue Using STack----------");
            QueueUsingStacks<int> qus = new QueueUsingStacks<int>();
            qus.Enqueue(3);
        }
    }
}
