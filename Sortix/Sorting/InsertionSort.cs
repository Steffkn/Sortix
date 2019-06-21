/*
 INSERTION-SORT (A)
1  for j <- 2 to length[A]
2       do key <- A[j]
3         Insert A[j] into the sorted sequence A[1 . . j - 1].
4        i <- j - 1
5        while i > 0 and A[i] > key
6           do A[i + 1] <- A[i]
7              i <- i - 1
8        A[i + 1] <- key
*/

using System;

namespace Sortix.Sorting
{
    public class InsertionSort : SortingAlgorithm
    {
        public override void Sort<T>(T[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                T key = array[j];
                int i = j - 1;

                // Move elements of arr[0..i-1], that are greater than key, 
                // to one position ahead of their current position 
                while (i >= 0 && array[i].CompareTo(key) > 0)
                {
                    array[i + 1] = array[i];
                    i = i - 1;
                }

                array[i + 1] = key;
            }
        }
    }
}
