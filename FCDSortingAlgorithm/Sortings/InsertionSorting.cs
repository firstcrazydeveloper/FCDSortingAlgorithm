using System;
using System.Collections.Generic;
using System.Text;

namespace FCDSortingAlgorithm.Sortings
{
    public class InsertionSorting
    {
        public int[] Sort(int[] arr)
        {
            // Worst Case Time Complexity [ Big-O ]: O(n2)
            // Best Case Time Complexity [Big-omega]: O(n)
            // Average Time Complexity [Big-theta]: O(n2)
            // Space Complexity: O(1)
            
            int i, j, key;
            for (i = 1; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    key = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = key;
                    j--;
                }
            }

            return arr;
        }
    }
}
