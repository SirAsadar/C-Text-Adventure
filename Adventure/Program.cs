using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            string characterName = "John";

            Console.WriteLine("Adventure in Eorza!");
            Console.WriteLine("Welcome to the world of Eorza! A land full of discovery and turmoil. You're stranded in the woods miles from any sort of civilization and all you have are the supplies in your pack. Survive. Good luck.");
            Console.WriteLine("Enter your name:");
            characterName = Console.ReadLine();
            Console.WriteLine("Welcome " + characterName + ", to the world of Eorza!" );
            Console.Read();

        }
    }
}
