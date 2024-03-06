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
    static void __init__(self):
        //Initialize the current value of the die
        self.current_value = 0

    static void roll(self):
        //Roll the die and update its current value
        self.current_value = random.randint(1, 6)
        return self.current_value
    }
}
