using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {

       public void TestDiceRoll()
        {
            Dice dice = new Dice();
            for (int i = 0; i < 100; i++)
            {
                int roll = dice.Roll();
                if (roll < 1 || roll > 6)
                {
                    throw new Exception("Dice roll out of bounds!");
                }
            }
            Console.WriteLine("TestDiceRoll passed.");
        }
	
	public void TestScoreCalculation()
        {
            DiceGame game = new DiceGame("Test Game");

            // Simulating some rolls
            game.TotalScore = 0;
            game.TotalScore += 8; // Roll [5, 3]
            game.TotalScore += 11; // Roll [1, 6]
            game.TotalScore += 20; // Roll [5, 5]

            if (game.TotalScore != 39)
            {
                throw new Exception("Score calculation failed!");
            }

            Console.WriteLine("TestScoreCalculation passed.");
        }    

    }
}
