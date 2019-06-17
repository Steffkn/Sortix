namespace Sortix.Sorting
{
    public class QuickSort : SortingAlgorithm
    {
        public override void Sort(double[] array)
        {
            quickSort(array, 0, array.Length - 1);
        }

        /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all 
    smaller (smaller than pivot) to left of 
    pivot and all greater elements to right 
    of pivot */
        static int partition(double[] array, int low, int high)
        {
            double pivot = array[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (array[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            double temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(double[] array, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(array, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(array, low, pi - 1);
                quickSort(array, pi + 1, high);
            }
        }
    }
}
