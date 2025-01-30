using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int nextNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ( ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber)) )
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"The current number is {currentNumber}");
        }
        public static int GetPot() { return pot; }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber >= half)
                Console.WriteLine($"The current number is {currentNumber}, the next number is at least {half}");
            else
                Console.WriteLine($"The current number is {currentNumber}, the next number is at most {half}");

        }
    }
}
