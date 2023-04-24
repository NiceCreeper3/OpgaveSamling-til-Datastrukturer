using System;
using DataStructures;
using Algorithms;

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
        /// <3.2>
        /// Implementer en binær søgealgoritme, for eksempel ved hjælp af følgende pseudokode: 
        /// </Opgave>
        static int[] Elements = { 1, 2, 6, 4, 5, 6, 15};
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.IsTheArraySorted(Elements));

            Console.WriteLine("Write the nummber you want");
            int TheNummberTheUserWants = int.Parse(Console.ReadLine());

            Class1.FindNummberIndArray(Elements , TheNummberTheUserWants);

        }
    }
}
