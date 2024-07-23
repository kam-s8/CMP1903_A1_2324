using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {    
	static void SevensOut()   
	{
		try
		{
               	 Dice dice1 = new Dice();
               	 Dice dice2 = new Dice();
               	 int totalScore = 0;

                while (true)
                {
                    int roll1 = dice1.Roll();
                    int roll2 = dice2.Roll();
                    int rollSum = roll1 + roll2;

                    Console.WriteLine($"Roll: [{roll1}, {roll2}] (Sum={rollSum})");

                    if (rollSum == 7)
                    {
                        Console.WriteLine($"End total = {totalScore}");
                        break;
                    }
                    else if (roll1 == roll2) // Check if it's a double
                    {
                        totalScore += rollSum * 2;
                    }
                    else
                    {
                        totalScore += rollSum;
                    }

                    Console.WriteLine($"Current total = {totalScore}");
		}
	}
	catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
    }
}
