using System;
namespace Adventure{
    public static class Game{
        static string characterName = "John";
        
        public static void StartGame(){
            //statements
            string title = @"

  __   ____  _  _  ____  __ _  ____  _  _  ____  ____        __  __ _        ____  __  ____  ____   __  
 / _\ (    \/ )( \(  __)(  ( \(_  _)/ )( \(  _ \(  __)      (  )(  ( \      (  __)/  \(  _ \(__  ) / _\ 
/    \ ) D (\ \/ / ) _) /    /  )(  ) \/ ( )   / ) _)        )( /    /       ) _)(  O ))   / / _/ /    \
\_/\_/(____/ \__/ (____)\_)__) (__) \____/(__\_)(____)      (__)\_)__)      (____)\__/(__\_)(____)\_/\_/
                                                                                                                                
        ";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWelcome to the world of Eorza! A land full of discovery and turmoil. You're stranded in the woods miles from any sort of civilization and all you have are the supplies in your pack. Survive. Good luck.");
            Console.ResetColor();
            NameCharacter();
            }
        public static void NameCharacter(){
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter your name:");
            Console.ResetColor();
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