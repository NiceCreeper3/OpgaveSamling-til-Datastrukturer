﻿using System;
using DataStructures;
using Algorithms;
using System.Diagnostics;

namespace DataStrugOp3
{
    class Program
    {

        /// <Opgave>
        /// <3> True
        /// Til resten af opgaverne i denne samling skal du oprette to biblioteker, DataStructures og Algorithms
        /// 
        /// <3.1> True
        /// Lav en funktion i Algorithms, der afgør om et array er sorteret eller ej. 
        /// Dette er en forudsætning for at kunne producere meningsfulde resultater fra binære søgninger, som næste opgave omhandler. 
        /// 
        /// <3.2> True
        /// Implementer en binær søgealgoritme, for eksempel ved hjælp af følgende pseudokode: 
        /// 
        /// <3.3> True
        /// Lav endnu en funktion i Algorithms,
        /// der foretager en lineær søgning efter et element i et array og returnerer indekset – ligesom den binære søgning. 
        /// 
        /// <3.4> True
        /// Fordi en binær søgning kræver at elementerne i arrayet er sorterede, og hvis der tillades dubletter, vil der blive fundet én af disse.
        /// Da arrayet er sorteret vil dubletterne altid være ved siden af hinanden.
        /// Tilføj funktioner, der finder den dublet der er længst til højre, henholdsvis den der er længst til venstre. 
        /// 
        /// <4>
        /// I dette kapitel skal du implementere forskellige sorteringsalgoritmer.  
        /// 
        /// <4.1>
        /// Du finder pseudokoden i Lecture Notes. For hver af disse sorteringsalgoritmer skal du gøre følgende: 
        /// 
        /// 1:	Forklar hvert skridt i algoritmen i et tekstbehandlingsprogram 
        /// 2:  Implementer algoritmen i Algorithms 
        /// 3:	Lav funktionstest der afprøver om algoritmen virkelig sorterer input 
        /// 4:	Lav efterprøvning af algoritmens tidkompleksitet med visuelle grafer, hvor n varierer fra 10 til 
        /// 1.000.000.000 i trin af 10, 100, 1.000, 10.000 osv.
        /// </Opgave>

        // Arrays 
        static int[] Elements = { 1, 2, 3, 4, 5, 6, 15};
        static int[] Elements2 = { 1, 2, 5, 4, 5, 6, 15 };
        static int[] Elements3 = new int[100000];

        static void Main(string[] args)
        {
            int[] currArray = Elements3;

            Random rnd = new Random();

            #region Op 3
/*            foreach (int a in currArray)
            {
                Console.Write(a + ", ");
            }*/
            Console.WriteLine();


            #region is sorted?
            //bool sorted = Class1.IsTheArraySorted(currArray);
            bool sorted = false;


            if (sorted)
                Console.WriteLine("the Array is sorted");
            else
                Console.WriteLine("the array is not sorted");
            #endregion

            #region Biner søning
            if (sorted)
            {
                Console.WriteLine("Write the nummber you want");
                int UserChose = int.Parse(Console.ReadLine());

                Class1.FindNummberIndArray(currArray, UserChose);
            }
            #endregion

            #region Liner Søning
            if (sorted)
            {
                Console.WriteLine("Write the nummber you want");
                int UserChose = int.Parse(Console.ReadLine());

                Class1.LinerSøgning(currArray, UserChose);
            }

            #endregion
            #endregion


            for (int i = 0; i < currArray.Length; i++)
            {
                currArray[i] = rnd.Next(1, 1000);
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Class1.MergeSort(currArray);
            stopWatch.Stop();


            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);


        }
    }
}
