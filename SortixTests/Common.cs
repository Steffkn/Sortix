using Sortix.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortixTests
{
    public class Common
    {
        public static bool IsSorted<T>(T[] array) where T : IComparable
        {
            // Our strategy will be to compare every element to its successor.
            // The array is considered unsorted
            // if a successor has a greater value than its predecessor.
            // If we reach the end of the loop without finding that the array is unsorted,
            // then it must be sorted instead.

            // Note that we are always comparing an element to its successor.
            // Because of this, we can end the loop after comparing 
            // the second-last element to the last one.
            // This means the loop iterator will end as an index of the second-last
            // element of the array instead of the last one.
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false; // It is proven that the array is not sorted.
                }
            }

            return true; // If this part has been reached, the array must be sorted.
        }

    }
}
