using System;
using System.Collections.Generic;
using System.Text;

namespace Sortix.Sorting
{
    public class MergeSort : SortingAlgorithm
    {
        public override void Sort(double[] array)
        {
            this.Sort(array, 0, array.Length - 1);
        }

        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        void Merge(double[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            // Find sizes of two subarrays to be merged 
            int leftSubArraySize = middleIndex - leftIndex + 1;
            int rightSubArraySize = rightIndex - middleIndex;

            /* Create temp arrays */
            double[] leftSubArray = new double[leftSubArraySize];
            double[] rightSubArray = new double[rightSubArraySize];

            /*Copy data to temp arrays*/
            for (int x = 0; x < leftSubArraySize; ++x)
                leftSubArray[x] = array[leftIndex + x];
            for (int y = 0; y < rightSubArraySize; ++y)
                rightSubArray[y] = array[middleIndex + 1 + y];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays 
            int i = 0, j = 0;

            // Initial index of merged subarry array 
            int k = leftIndex;
            while (i < leftSubArraySize && j < rightSubArraySize)
            {
                if (leftSubArray[i] <= rightSubArray[j])
                {
                    array[k] = leftSubArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightSubArray[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of leftSubArray[] if any */
            while (i < leftSubArraySize)
            {
                array[k] = leftSubArray[i];
                i++;
                k++;
            }

            /* Copy remaining elements of rightSubArray[] if any */
            while (j < rightSubArraySize)
            {
                array[k] = rightSubArray[j];
                j++;
                k++;
            }
        }

        void Sort(double[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                // Sort first and second halves 
                Sort(arr, leftIndex, middleIndex);
                Sort(arr, middleIndex + 1, rightIndex);

                // Merge the sorted halves 
                Merge(arr, leftIndex, middleIndex, rightIndex);
            }
        }
    }
}
