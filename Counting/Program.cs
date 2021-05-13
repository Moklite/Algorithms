using System;

namespace Counting
{
    class Program
    {
        static int CountIfAbove(int[] collection, int key)
        {
            int counter = 0;
            for(int i=0; i<collection.Length; i++)
            {
                if(collection[i] > key)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int count = CountIfAbove(numbers, 42);
            Console.WriteLine("Numbers above 42 ... Amount: {0}", count);
            Console.ReadLine();
        }
    }
}
