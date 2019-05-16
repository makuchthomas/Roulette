using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src
{
    public class GameMode
    {
        public static void SelectGameMode()
        {
            Console.WriteLine("SELECT MODE");
            Console.WriteLine("Mode 1: Program executes all games and finally print summary in form (Press 1)");
            Console.WriteLine("Mode 2: Each player bets numbers, program selects some number and writes who has chosen right (Press 2)");
            Console.WriteLine("Mode 3: Exit (Press 3)");

            string inputGameMode = Console.ReadLine();

            try
            {
                int result = int.Parse(inputGameMode);

                switch (result)
                {
                    case 1:
                        ModeOne.RunMode();
                        break;
                    case 2:
                        ModeTwo.RunMode();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Press 1 or 2 to select game mode. Select 3 to exit.");
                        SelectGameMode();
                        break;
                }
            }
            catch (FormatException)
            {
                SelectGameMode();
            }
        }

    }
}
