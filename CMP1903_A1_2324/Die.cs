﻿using System;
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
		
		//method
		//create a method that generates a random number 1-6 and it returns that value to anything that calls this method
		public static int Roll()
        {
			//Console.WriteLine("The code is still working.")
			Random rnd = new Random();
			//randomise the number
			int dieNumber = rnd.Next(1, 7);
			//return the number
			return dieNumber;
        }
}
