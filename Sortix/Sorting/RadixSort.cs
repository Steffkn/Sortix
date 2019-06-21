using System;
using System.Collections.Generic;
using System.Text;

namespace Sortix.Sorting
{
    public class RadixSort : SortingAlgorithm
    {
        public override void Sort<T>(T[] array)
        {
            //radixsort(array);
        }

        public static double getMax(double[] array)
        {
            double mx = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > mx)
                    mx = array[i];
            return mx;
        }

        // A function to do counting sort of arr[] according to  
        // the digit represented by exp.  
        public static void countSort(double[] array, int exp)
        {
            double[] output = new double[array.Length]; // output array  
            int[] count = new int[10];
            int precission = 10;

            //initializing all elements of count to 0 
            for (int i = 0; i < 10; i++)
                count[i] = 0;

            // Store count of occurrences in count[]  
            for (int i = 0; i < array.Length; i++)
            {
                count[(long)((array[i] / exp) * precission) % 10]++;
            }

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[(long)((array[i] / exp) * precission) % 10] - 1] = array[i];
                count[(long)((array[i] / exp) * precission) % 10]--;
            }

            // Copy the output array to arr[], so that arr[] now  
            // contains sorted numbers according to current digit  
            for (int i = 0; i < array.Length; i++)
                array[i] = output[i];
        }

        // The main function to that sorts arr[] of size n using   
        // Radix Sort  
        public static void radixsort(double[] array)
        {
            // Find the maximum number to know number of digits  
            double m = getMax(array);

            // Do counting sort for every digit. Note that instead  
            // of passing digit number, exp is passed. exp is 10^i  
            // where i is current digit number  
            for (int exp = 1; m / exp > 0; exp *= 10)
                countSort(array, exp);
        }
    }
}
