using System;
using System.Collections.Generic;
using System.Text;

namespace FCDSortingAlgorithm.Sortings
{
    public class SortingCaller
    {
        // https://www.studytonight.com/data-structures/insertion-sorting
        public SortingCaller()
        {
            InsertionSorting();
            QuickSorting();
        }
        public void InsertionSorting()
        {
            int[] array = new int[] { 5, 1, 6, 2, 4, 3 };
            InsertionSorting insertionSorting = new InsertionSorting();
            var sortedData = insertionSorting.Sort(array);
        }

        public void QuickSorting()
        {
            int[] array = new int[] { 5, 1, 6, 2, 4, 3 };
            QuickSorting quickSorting = new QuickSorting();
            var sortedData = quickSorting.Sort(array);
        }
    }
}
