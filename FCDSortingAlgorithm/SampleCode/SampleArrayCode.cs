using System;
using System.Collections.Generic;
using System.Text;

namespace FCDSortingAlgorithm.SampleCode
{
    public class SampleArrayCode
    {

        public int GetCommonElementFromSortedArray(int[] sourceArray, int[] targetArray)
        {
            // Time Complexity >> O(n)
            // Space Complexity >> O(1)
            int pointer1 = 0;
            int pointer2 = 0;
            int count = 0;
            while (true)
            {
                if (sourceArray[pointer1] == targetArray[pointer2])
                {
                    count++;
                    pointer1++;
                    pointer2++;

                }
                else if (sourceArray[pointer1] < targetArray[pointer2])
                {
                    pointer1++;
                }
                else
                {
                    pointer2++;
                }

                if (pointer1 >= sourceArray.Length || pointer2 >= targetArray.Length)
                    break;

            }

            return count;
        }

        public IDictionary<string, int> GetDuplicateWords(string[] wordArray)
        {
            // Time Complexity >> O(n)
            // Space Complexity >> O(n)
            IDictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in wordArray)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }

            }

            return wordCount;
        }
    }
}
