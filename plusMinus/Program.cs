using System;

namespace plusMinus
{
    class Program
    {
        //Given an array of integers, calculate the ratios of its elements that are positive, 
        //negative, and zero. Print the decimal value of each fraction on a new line with 6 places after the decimal.

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            var len = arr.Length;
            decimal positiveResultCount = 0;
            decimal negativeResultCount = 0;
            decimal zeroResultCount = 0;

            foreach(var item in arr)
            {
                if (item > 0)
                    positiveResultCount += 1;
                if (item < 0)
                    negativeResultCount += 1;
                if (item == 0)
                    zeroResultCount += 1;
            }
            var positiveFraction = (positiveResultCount / len).ToString("N6");
            var negativeFraction = (negativeResultCount / len).ToString("N6");
            var zeroFraction = (zeroResultCount / len).ToString("N6");
            Console.WriteLine(positiveFraction);
            Console.WriteLine(negativeFraction);
            Console.WriteLine(zeroFraction);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
