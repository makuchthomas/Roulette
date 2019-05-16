using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Common
{
    public class NumberOfGames
    {
        public static int Number()
        {
            Console.WriteLine("Insert number of games:");
            string numberOfGames = Console.ReadLine();
            try
            {
                int newNumberOfGames = int.Parse(numberOfGames);
                if (newNumberOfGames <= 0)
                {
                    Console.WriteLine("Incorrect input. Number of games should be a positive");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input.");
                Number();
            }

            return int.Parse(numberOfGames);
        }
    }
}
