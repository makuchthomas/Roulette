using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.src.Mode1
{
    public class Draw
    {

        public static int[] Random(int numberOfGames)
        {

            Random random = new Random();

            int[] result = new int[numberOfGames];
            while (numberOfGames > 0)
            {
                int number = random.Next(0, 36);
                result[numberOfGames - 1] = number;
                numberOfGames -= 1;
            }

            return result;

            #region Test
            /*foreach (var element in result)
             {
                 Console.WriteLine(element);
             }*/
            #endregion
        }
    }
}
