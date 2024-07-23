using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Dice
    {
        private static Random random = new Random();

        public int Roll()
        try //wrapping this part of the code in a try catch block to catch and handle any potential error.
            {
                return random.Next(1, 7);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while rolling the dice: {ex.Message}");
                // Return a safe default value or rethrow the exception
                return 1;
            }
    }
}
