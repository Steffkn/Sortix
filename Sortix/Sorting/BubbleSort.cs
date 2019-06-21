using System;
using System.Collections.Generic;
using System.Text;

namespace Sortix.Sorting
{
    public class BubbleSort : SortingAlgorithm
    {
        public override void Sort<T>(T[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        // swap temp and arr[i] 
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
