using System;

namespace Algorithms
{
    public class Class1
    {

        /// <summary>
        /// Cheakes eathe nummber ind a array if its smaller then the next nummber
        /// </summary>
        /// <param name="ArrayCheck"></param>
        /// <returns> the Array is sorted </returns>
        public static string IsTheArraySorted(int[] ArrayCheck)
        {
            // goves frue ithe nummber to check Exept fuor the last number
            // beckase if we reathe the last nummber then we know it is korekt
            for (int i = 0; i < ArrayCheck.Length - 1; i++)
            {
                if (ArrayCheck[i] > ArrayCheck[i + 1])
                    return "the array is not sorted";
            }

            return "the Array is sorted";
        }

        public static void FindNummberIndArray(int[] ArrayFind, int TheNummberTheUserWants)
        {
            bool TriningToFindNummber = true;
            int low = 0;
            int Hight = ArrayFind.Length - 1;



            // get det middel of a array
            while (TriningToFindNummber == true)
            {
                // gets the hafe waje nummber of Hight and Low
                int mid = low + ((Hight - low) / 2);

                if (ArrayFind[mid] == TheNummberTheUserWants)
                {
                    Console.WriteLine("you nummber: " + ArrayFind[mid] + " is ind Colume: " + mid);
                    TriningToFindNummber = false;

                }
                else if (low >= Hight) // Makes sure if the nummber is not ind the program. that it stopes the reapite.
                {
                    Console.WriteLine("this nummber is not in the Array");
                    TriningToFindNummber = false;
                }
                // sørger vi gøre en fram ad fordi vi alledet har teastet det gammle 
                else if (ArrayFind[mid] < TheNummberTheUserWants)
                    low = mid + 1;
                else
                    Hight = mid - 1;
            }
        }

    }
}
