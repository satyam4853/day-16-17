using System;

namespace Angram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Angram Programme");
            string firstString, secondString;
            //Gets words from user.  
            Console.WriteLine("Enter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("Enter second string");
            secondString = Console.ReadLine();
            Angram anagram = new Angram();
            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string.");
            }
            else
            {
                Console.WriteLine("Both string are not anagram string.");
            }
            Console.ReadLine();
        }
    }
}

