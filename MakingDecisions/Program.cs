using System;

namespace MakingDecisions
{
    class Program
    {
        static bool MaxValueAboveTen(int[] collection)
        {
            for(int i=0; i<collection.Length; i++)
            {
                if(collection[i] > 10)
                {
                    return true;
                }
            }
            return false;
        }

        static bool MaxValueAbove(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] > value)
                {
                    return true;
                }
            }
            return false;
        }

        static bool Decide(int[] collection, Func<int,bool> condition)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (condition(collection[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsNegative(int number)
        {
            if (number < 0)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            
            int[] arrayOfIntegers = {0,1,2,3,4,5,6,-7,8,9,10};
            Console.WriteLine("The collection has an element that is higher than 10: {0}", MaxValueAboveTen(arrayOfIntegers));

            int index = 3;
            bool hasValueAboveThree = MaxValueAbove(arrayOfIntegers, index);
            Console.WriteLine("The collection has an element that is higher than {0}: {1}", index, hasValueAboveThree);

            bool hasNegativeNumber = Decide(arrayOfIntegers, IsNegative);
            Console.WriteLine("The collection has negative number: {0}", hasNegativeNumber);

            Console.ReadLine();
        }
    }
}
