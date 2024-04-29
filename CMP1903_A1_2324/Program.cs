using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make a menu that appears as soon as the program runs
            Console.WriteLine("Welcome to the Game Menu!");
            Console.WriteLine("Please select a game to play:");
            Console.WriteLine("1. SevensOut");
            Console.WriteLine("2. Stats");
            Console.WriteLine("3. Exit");

            bool exitRequested = false;
            while (!exitRequested)
            {
            Console.Write("Enter your choice: 1-3");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Starting SevensOut");
                    // Call the method to start SevensOut
                    Roll();
                    break;
                case "2":
                    Console.WriteLine("Here are your stats:");
                    Console.WriteLine($"Highscore : {maximum}");
                    Console.WriteLine($"Average Score : {total}");
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 2.");
                    break;
            }
            }
            
            Testing.testDie(); //check if dice are rolling as intended
            Testing.testMenu(); //check if menu method is running/called
        }
    }
}
