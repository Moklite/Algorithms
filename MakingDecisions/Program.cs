using System;

namespace MakingDecisions
{
    class Program
    {
        static bool MaxValueAboveTen(int[] colection)
        {
            for(int i=0; i<colection.Length; i++)
            {
                if(colection[i] > 10)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            
            int[] arrayOfIntegers = {0,1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("The collection has an element that is higher than ten: {0}", MaxValueAboveTen(arrayOfIntegers));
            Console.ReadLine();
        }
    }
}
