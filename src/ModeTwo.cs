using Roulette.src.Common;
using Roulette.src.Mode2;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src
{
    public class ModeTwo
    {
        public static void RunMode()
        {
            #region Players&Games
            int numberOfPlayers = NumberOfPlayers.Number();
            int numberOfGames = NumberOfGames.Number();
            Random random = new Random();
            Dictionary<string, Dictionary<int, int[]>> gambler = Player.CreatePlayer(numberOfPlayers, numberOfGames);
            #endregion

            #region View
            Console.WriteLine("TOTAL NUMBER OF PLAYERS: " + numberOfPlayers);
            Console.WriteLine("TOTAL NUMBER OF GAMES: " + numberOfGames);

            int countingDown = 0;
            while (numberOfGames != countingDown)
            {
                int drawResult = random.Next(0, 36);
                //int[] drawResult = Draw.Random(numberOfGames);

                Console.WriteLine("GAME NUMBER: " + (countingDown + 1));

                Console.Write("BET NUMBERS: ");
                foreach (var item in gambler)
                {

                    foreach (var value in item.Value)
                    {
                        foreach (var bet in value.Value)
                        {
                            Console.Write(bet + ", ");

                            var win = new List<string>();

                            Console.Write("\nWIN NUMBER: " + drawResult);

                            Console.Write("\nWINNERS: ");

                            //Output WIN
                            if (win.Count == 0)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                foreach (var number in win)
                                {
                                    Console.Write(number + ", ");
                                }
                            }

                        }

                    }
                    Console.WriteLine();

                    countingDown += 1;
                }
                #endregion
            }
        }
    }
}
