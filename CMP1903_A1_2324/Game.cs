using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
            class Game:
    def __init__(self):
        //Initialize the game with three dice and total score set to zero
        self.dice = [Die() for _ in range(3)]
        self.total = 0

    def roll_all_dice(self):
        //Roll all dice and calculate the total score
        self.total = 0
        for die in self.dice:
            roll_result = die.roll()  # Roll each die
            print("Die roll:", roll_result)
            self.total += roll_result  # Accumulate the total score

        print("Total of all rolls:", self.total)
        return self.total


    }
}
