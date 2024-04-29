using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
	//Create the die object property with a value so it can be assigned a value
	public int Value{get; set;}
        public Die(int value)
        {
            Value = value;
        }
	publi Dice();
	 {
		total1 = 0;
		total2 = 0;
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
