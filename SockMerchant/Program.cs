using System;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var count = 0;
            
            
            foreach (var item in ar)
            {
                var itemIndex = Array.IndexOf(ar, item);

                if (ar.Count() < n)
                {
                    n = ar.Count();
                }

                for (var i = 0; i < n ; i++)
                {

                    if (ar[i] == item && i != Array.IndexOf(ar, item))
                    {
                        count++;
                        ar = ar.Where((val, idx) => idx != itemIndex).ToArray();
                        ar = ar.Where((val, idx) => idx != i-1).ToArray();
                        break;
                    }
                }

            }


            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
