using System;

namespace SumOfNumbers
{
    class Program
    {
        static int SumNumbers(int a, int b)
        {
            return a + b;
        }

        static int SumNumbersTwo(int[] arr)
        {
            var total = 0;
            var len = arr.Length;

            if(len > 0)
            {
                foreach (var item in arr)
                {
                    total += item;
                }
            }
            

            return total;
        }
        static void Main(string[] args)
        {
            SumNNumbers numbers = new SumNNumbers();
            var total = SumNumbers(3, 6);
            Console.WriteLine("Total = {0}", total);

            Console.WriteLine("Enter numbers separated by comma");
            int[] arrs = Array.ConvertAll(Console.ReadLine().Split(','), arrTemp => Convert.ToInt32(arrTemp));
            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            var totalTwo = SumNumbersTwo(arrs);
            Console.WriteLine("Total Two = {0}", totalTwo);

            Console.WriteLine("Enter number n");
            int n = Convert.ToInt32(Console.ReadLine());
            var defineSum = numbers.NSum(n);
            Console.WriteLine("Total three = {0}", defineSum);
        }
    }
}
