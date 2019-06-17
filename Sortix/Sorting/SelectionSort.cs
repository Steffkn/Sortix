using System;
using System.Collections.Generic;
using System.Text;

namespace Sortix.Sorting
{
    public class SelectionSort : SortingAlgorithm
    {
        public override void Sort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min_index = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min_index])
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
