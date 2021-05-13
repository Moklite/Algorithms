using System;
using System.Collections.Generic;
using System.Linq;

namespace diagonalDifference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int DiagonalDifference(List<List<int>> arr)
        {
            var firstSum = 0;
            var secondSum = 0;
            var result = 0;
            int i = 0;
            
            foreach (var sublist in arr)
            {
                int ind = 0;

                int len = sublist.Count();

                foreach (var value in sublist)
                {
                    if (ind == i)
                    {
                        firstSum += value;
                    }
                    if (ind == (len-1-i))
                    {
                        secondSum += value;
                    }
                    ind++;
                }
                i++;
            }

            result = Math.Abs((firstSum - secondSum));
            return result;
        }

    }

    class Program
    {

        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.DiagonalDifference(arr);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
