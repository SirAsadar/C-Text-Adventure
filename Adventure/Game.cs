using System;
namespace Adventure{
    public static class Game{
        static string characterName = "John";

        public static void StartGame(){
            //statements
            Console.WriteLine("Adventure in Eorza!");
            Console.WriteLine("Welcome to the world of Eorza! A land full of discovery and turmoil. You're stranded in the woods miles from any sort of civilization and all you have are the supplies in your pack. Survive. Good luck.");
            NameCharacter();
            }
        public static void NameCharacter(){
            Console.WriteLine("Enter your name:");
            characterName = Console.ReadLine();
            Console.WriteLine("Welcome " + characterName + ", to the world of Eorza!" );
        }
        static void Dialog(string message, string color){
            
            if(color == "red"){
                Console.ForegroundColor = ConsoleColor.Red;
            } else if(color == "yellow"){
                Console.ForegroundColor = ConsoleColor.Yellow;
            } else if(color == "green"){
                Console.ForegroundColor = ConsoleColor.Green;
            } else {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}