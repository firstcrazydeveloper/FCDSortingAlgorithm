using System;
using System.Collections.Generic;
using System.Text;

namespace FCDSortingAlgorithm.SampleCode
{
    public class SampleCodeCaller
    {
        public SampleCodeCaller()
        {
            CountCommonElements();
        }
        public void CountCommonElements()
        {
            SampleArrayCode SampleArrayCode = new SampleArrayCode();
            int[] array1 = new int[] { 7, 15, 21, 35, 65, 96 };
            int[] array2 = new int[] { 13, 21, 28, 35, 72, 85, 96 };
            var countCommonElements = SampleArrayCode.GetCommonElementFromSortedArray(array1, array2);
        }
       
    }
}
