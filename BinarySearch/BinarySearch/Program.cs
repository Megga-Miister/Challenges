using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        //structured off of wikipedia psuedocode for Binary Search Algorithm
        /// <summary>
        /// Iterates through sorted array to find values matching the target search key. Outputs index of array element that matches so -1 when matching element does not exist. 
        /// </summary>
        /// <param name="sortedArray">An array of integers sorted from lowest element value to highest element value</param>
        /// <param name="searchKey">An integer whose value you are looking to find if a matching array element's value exists</param>
        /// <returns>Either the index of a matching element value or -1 if there are no equal values</returns>
        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            int min = 0;
            int last = sortedArray.Length - 1;

            while (min <= last)
            {
                int middle = (min + last) / 2;

                if(sortedArray[middle] < searchKey)
                {
                    min = middle + 1;
                } else if(sortedArray[middle] > searchKey)
                    {
                        last = middle - 1;
                    } else
                        {
                            return middle;
                        } 
            }
            return -1;
        }

    }
}
