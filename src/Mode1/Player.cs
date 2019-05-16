using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Mode1
{
    public class Player
    {
        public static Dictionary<string, int[]> CreatePlayer(int numberOfPlayers, int numberOfGames)
        {
            Dictionary<string, int[]> gambler = new Dictionary<string, int[]>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter player name:");
                string inputName = Console.ReadLine();
                gambler.Add(inputName, EnterYourBets(numberOfGames));
            }

            #region Test
            // Test results
            /*foreach (var item in gambler)
            {
                Console.Write(item.Key);
                Console.Write("\n");
                foreach (var val in item.Value)
                {
                    Console.Write(val);
                }
            }*/
            #endregion
            return gambler;
        }

        public static int[] EnterYourBets(int numberOfGames)
        {
            Console.WriteLine("Enter your bets (The bet must be between 0-36).");
            int[] bets = new int[numberOfGames];
            while (numberOfGames > 0)
            {
                string bet = Console.ReadLine();
                try
                {
                    int newBet = int.Parse(bet);
                    if (newBet < 0 || newBet > 36)
                    {
                        Console.WriteLine("Incorrect input. The bet must be between 0-36.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input.");
                }
                bets[numberOfGames - 1] = int.Parse(bet);
                numberOfGames -= 1;
            }

            return bets;
        }
    }
}
