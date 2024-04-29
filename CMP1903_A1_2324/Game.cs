using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
     public Dice();
	 {
		 public int total1 = 0;
		 public int total2 = 0;
	 }
	//method
	public static int Roll()
    {
		int roll1 = random.Next(1,7);
		int roll2 = random.Next(1,7);
		total1 += roll1;
		total2 += roll2;

		Console.WriteLine($"Current Roll: {roll1}, Total : {total1}");
		Console.WriteLine($"Current Roll: {roll2}, Total : {total2}");

		if (roll1 == 7 || roll2 == 7)
		{
			Console.WriteLine("One of the dice has landed on 7, stop rolling.");
		}

    }

    }
}
