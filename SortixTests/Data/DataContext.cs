using Sortix.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortixTests.Data
{
    public class DataContext
    {
        public static readonly List<SortingAlgorithm> SortingAlgorithms = new List<SortingAlgorithm>
        {
                new BubbleSort(),
                new InsertionSort(),
                new MergeSort(),
                new QuickSort(),
                new RadixSort(),
                new SelectionSort(),
        };

        public static readonly int[] SimpleArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static readonly List<int[]> SortedIntegers = new List<int[]>
        {
            new int[] { -45, -35, -31, -24, -11, -9, -7, -1, 0, 6, 8, 13, 15, 19, 25, 29, 40, 41, 42, 49 },
            new int[] { -46, -35, -31, -29, -28, -27, -15, -14, -10, -7, -1, 2, 7, 8, 15, 20, 21, 25, 34, 47 },
            new int[] { -37, -30, -26, -22, -15, -5, -4, -3, 15, 16, 18, 23, 28, 30, 36, 38, 45, 48, 49, 50 }
        };

        public static readonly List<int[]> SortedIntegersWithDiplicates = new List<int[]>
        {
            new int[] { -45, -35, -35, -35, -31, -31, -31, -24, -24, -24, -11, -11, -11, -9, -9, -9, -7, -1, 0, 6, 8, 13, 15, 19, 25, 29, 40, 41, 42, 49 },
            new int[] { -46, -35, -35, -35, -31, -31, -31, -29, -29, -29, -28, -28, -28, -27, -27, -27, -15, -14, -10, -7, -1, 2, 7, 8, 15, 20, 21, 25, 34, 47 },
            new int[] { -37, -30, -30, -30, -26, -26, -26, -22, -22, -22, -15, -15, -15, -5, -5, -5, -4, -3, 15, 16, 18, 23, 28, 30, 36, 38, 45, 48, 49, 50 }
        };

        public static readonly List<int[]> UnorderedIntegers = new List<int[]>
        {

            new int[] { 10, -42, -32, 46, -15, -2, 29, 25, 43, -19, -10, -21, -47, -30, -24, 36, 48, 50, 28, 35 },
            new int[] { -13, -37, 21, -3, 11, 34, -48, 44, -14, -8, -32, 31, 10, 37, -30, 47, -41, -29, 39, 35 },
            new int[] { -35, -9, -38, -44, -17, -3, -22, 25, 2, 42, -27, 48, 50, 41, 6, -26, -48, -23, -11, 15 }
        };

        public static readonly List<int[]> UnorderedIntegersWithDiplicates = new List<int[]>
        {
            new int[] { 10, -42, -32, 10, -42, -32, 46, -15, -2, 29, 25, 43, -19, -10, -21, -47, -30, -24, 36, -30, -24, 36, 48, 50, 28, 35 },
            new int[] { -13, -37, 21,-13, -37, 21, -3, 11, 34, -48, 44, -14, -8, -32, 31, 10, 37, -30, 47, -41, -30, 47, -41, -29, 39, 35 },
            new int[] { -35, -9, -38, -35, -9, -38, -44, -17, -3, -22, 25, 2, 42, -27, 48, 50, 41, 6, -26, -48,  6, -26, -48, -23, -11, 15 }
        };
    }
}
