using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Mode2
{
    public class Player
    {
        public static Dictionary<string, Dictionary<int, int[]>> CreatePlayer(int numberOfPlayers, int numberOfGames)
        {
            Dictionary<string, Dictionary<int, int[]>> gambler = new Dictionary<string, Dictionary<int, int[]>>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter player name:");
                string inputName = Console.ReadLine();
                Dictionary<int, int[]> allBets = EnterYourBets(numberOfGames);

                gambler.Add(inputName, allBets);
            }

            return gambler;
        }
        public static Dictionary<int, int[]> EnterYourBets(int numberOfGames)
        {

            Dictionary<int, int[]> allBets = new Dictionary<int, int[]>();

            while (numberOfGames != 0)
            {
                Random random = new Random();
                int numberOfBets = random.Next(1, 3);
                Console.WriteLine("Enter " + numberOfBets + " bet(s). (The bet must be between 0-36).");
                int[] bets = new int[numberOfBets];
                while (numberOfBets > 0)
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
                    bets[numberOfBets - 1] = int.Parse(bet);
                    numberOfBets -= 1;
                }
                allBets.Add(numberOfGames, bets);

                numberOfGames -= numberOfGames;
            }

            return allBets;
        }
    }
}
