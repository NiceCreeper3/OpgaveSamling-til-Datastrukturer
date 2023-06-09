﻿using System;

namespace Algorithms
{
    public class Class1
    {

        /// <summary>
        /// Cheakes eathe nummber ind a array if its smaller then the next nummber
        /// </summary>
        /// <param name="ArrayCheck"></param>
        /// <returns> the Array is sorted </returns>
        public static bool IsTheArraySorted(int[] ArrayCheck)
        {
            // goves frue ithe nummber to check Exept fuor the last number
            // beckase if we reathe the last nummber then we know it is korekt
            for (int i = 0; i < ArrayCheck.Length - 1; i++)
            {
                if (ArrayCheck[i] > ArrayCheck[i + 1])
                    return false;
            }

            return true;
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
                    while (ArrayFind[mid - 1] == TheNummberTheUserWants)
                        mid--;
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
        public static int LinerSøgning(int[] ArrayFind, int TheNummberTheUserWants)
        {
            foreach (int a in ArrayFind)
            {
                if (a == TheNummberTheUserWants)
                    return a;
                else if (a > TheNummberTheUserWants)
                    return -1;

            }
            return -1;
        }

        #region Op 4
        public static void InsertionSort(int[] values)
        {
            for (int sorted = 1; sorted < values.Length; sorted++) // hvilken plads er vi nået til 
            {
                int kandidat = values[sorted];
                bool flag = false;
                for (int i = sorted - 1; i >= 0 && flag == false;)
                {
                    if (kandidat < values[i])
                    {
                        values[i + 1] = values[i];
                        i--;
                        values[i + 1] = kandidat;
                    }
                    else flag = true;
                }
                /*Console.WriteLine();
                foreach (int e in Elements) 
                { 
                    Console.Write(e + " "); 
                }*/
            }
        }

        public static void BubbleSort(int[] values)
        {
            int n = values.Length;
            for (int sorted = 0; sorted < n - 1; sorted++)
            {
                for (int i = 0; i < n - sorted - 1 /*&& flag == false*/; i++)
                {
                    if (values[i + 1] < values[i])
                    {
                        Swap(i + 1, i, values);
                    }
                }
            }
        }

        public int[] MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }
        public void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }


        static void Swap(int a, int b, int[] values)
        {
            int temp = values[b];
            values[b] = values[a];
            values[a] = temp;
        }
        #endregion

    }
}
