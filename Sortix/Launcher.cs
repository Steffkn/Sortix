using Sortix.Shuffling;
using Sortix.Sorting;
using System;

namespace Sortix
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 1.15, 2.78, 3.785, 4.7867, 4.467, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Shuffle(array);
            PrintArray(array);
            var sortingAlgorithm = new RadixSort();
            sortingAlgorithm.Sort(array);
            PrintArray(array);
        }

        private static void Shuffle(double[] array)
        {
            var shuffler = new Shuffler(new Random());
            shuffler.Shuffle(array);
        }

        private static void TestShuffling()
        {
            var shuffler = new Shuffler(new Random());

            double[] array = new double[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            PrintArray(array);

            for (int i = 0; i < 10; i++)
            {
                shuffler.Shuffle(array);
                Console.WriteLine();
                PrintArray(array);
            }
        }

        private static void PrintArray(double[] array)
        {
            foreach (var number in array)
            {
                Console.Write("{0}", (number + " ").PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}
