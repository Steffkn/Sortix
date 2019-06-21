using System;
using System.Collections.Generic;
using System.Text;

namespace Sortix.Sorting
{
    public class SelectionSort : SortingAlgorithm
    {
        public override void Sort<T>(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min_index]) < 1)
                    {
                        min_index = j;
                    }
                }

                var temp = array[i];
                array[i] = array[min_index];
                array[min_index] = temp;
            }
        }
    }
}
