using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Mode2
{
    public class NumberOfBets
    {
        public static int Number()
        {
            Console.WriteLine("Insert number of bets:");
            string numberOfBets = Console.ReadLine();
            try
            {
                int newNumberOfBets = int.Parse(numberOfBets);
                if (newNumberOfBets <= 0)
                {
                    Console.WriteLine("Incorrect input. Number of bets should be a positive.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input.");
                Number();
            }

            return int.Parse(numberOfBets);
        }
    }
}
