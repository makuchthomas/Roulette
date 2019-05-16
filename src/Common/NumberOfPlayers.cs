using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Common
{
    public class NumberOfPlayers
    {
        public static int Number()
        {
            Console.WriteLine("Insert number of players:");
            string numberOfPlayers = Console.ReadLine();
            try
            {
                int newNumberOfPlayers = int.Parse(numberOfPlayers);
                if (newNumberOfPlayers <= 0)
                {
                    Console.WriteLine("Incorrect input. Number of players should be a positive.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input.");
                Number();
            }

            return int.Parse(numberOfPlayers);
        }
    }
}
