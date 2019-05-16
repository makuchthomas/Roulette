using Roulette.src.Mode1;
using Roulette.src.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette.src
{
    public class ModeOne
    {
        public static void RunMode()
        {
            #region Players&Games
            int numberOfPlayers = NumberOfPlayers.Number();
            int numberOfGames = NumberOfGames.Number();

            int[] drawResult = Draw.Random(numberOfGames);
            Dictionary<string, int[]> gambler = Player.CreatePlayer(numberOfPlayers, numberOfGames);
            #endregion

            #region View
            Console.WriteLine("TOTAL NUMBER OF PLAYERS: " + numberOfPlayers);
            Console.WriteLine("TOTAL NUMBER OF GAMES: " + numberOfGames);
            Console.WriteLine("RESULTS");
            Console.WriteLine("GAME    WIN NUMBER");

            int countingDown = 1;
            foreach (var drawNumber in drawResult)
            {
                Console.WriteLine(countingDown + "      " + drawNumber);
                countingDown += 1;
            }

            Console.WriteLine("PLAYER      BET      WIN      LOSE");
            while (numberOfPlayers > 0)
            {
                foreach (var item in gambler)
                {
                    //Output PLAYER
                    Console.Write(item.Key);
                    Console.Write("      ");

                    //Output BET
                    foreach (var val in item.Value)
                    {
                        Console.Write(val + ", ");
                    }
                    Console.Write("      ");

                    //Lists of elements
                    var win = new List<int>();
                    var lose = new List<int>();
                    foreach (var value in item.Value)
                    {
                        if (drawResult.Contains(value))
                        {
                            win.Add(value);
                        }
                        else
                        {
                            lose.Add(value);
                        }
                    }

                    //Output WIN
                    foreach (var element in win)
                    {
                        Console.Write(element + ", ");
                    }
                    Console.Write("      ");

                    //Output LOSE
                    foreach (var element in lose)
                    {
                        Console.Write(element + ", ");
                    }

                    Console.WriteLine();
                }
                numberOfPlayers = -1;
                #endregion
            }
        }
    }
}
