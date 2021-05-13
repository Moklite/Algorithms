using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class BinarySearchImplemented
    {
        static int BinarySearch(int[] collection, int valueToFind)
        {
            Array.Sort(collection);
            int firstIndex = 0;
            int lastIndex = collection.Length - 1;
            while (firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;
                if (collection[middleIndex] == valueToFind)
                {
                    return collection[middleIndex];
                }
                else if (valueToFind < collection[middleIndex])
                {
                    lastIndex = middleIndex - 1;
                }
                else
                {
                    firstIndex = middleIndex + 1;
                }
            }

            return -1;
        }

        public static void search()
        {
            //Binary Search - elements must be in order

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int[] numbers2 = { 10, 200, 30, 40, 510, 60, 70, 9, 90 };

            var searchResult = BinarySearch(numbers, 50);
            var searchResult2 = BinarySearch(numbers2, 50);

            if (searchResult != -1)
            {
                Console.WriteLine("The value {0} has been found", searchResult);
            }
            else
            {
                Console.WriteLine("The value could not be found in the collection");
            }

            if (searchResult2 != -1)
            {
                Console.WriteLine("The value {0} has been found in the second collection", searchResult2);
            }
            else
            {
                Console.WriteLine("The value {0} could not be found in the second collection", searchResult2);
            }
        }
    }
}
