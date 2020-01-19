using System;
using System.Collections.Generic;
using System.Text;

namespace FCDSortingAlgorithm.Sortings
{
    public class QuickSorting
    {
        public int[] Sort(int[] array)
        {
            // Worst Case Time Complexity [ Big-O ]: O(n2)
            // Best Case Time Complexity [Big-omega]: O(n*log n)
            // Average Time Complexity [Big-theta]: O(n*log n)
            // Space Complexity: O(n*log n)
            
            Quicksort(array, 0, array.Length - 1);
            return array;

        }

        void Quicksort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    Quicksort(array, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    Quicksort(array, pivot + 1, right);
                }
            }
        }

        int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];  // selecting last element as pivot
            int i = (low - 1);  // index of smaller element

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or equal to pivot
                if (array[j] <= pivot)
                {
                    i++;    // increment index of smaller element
                    Swap(array, i, j);
                }
            }

            Swap(array, (i + 1), high);
            return (i + 1);
        }

        void Swap(int[] array, int sourceIndex, int targetIndex)
        {
            int temp = array[sourceIndex];
            array[sourceIndex] = array[targetIndex];
            array[targetIndex] = temp;
        }
    }
}
