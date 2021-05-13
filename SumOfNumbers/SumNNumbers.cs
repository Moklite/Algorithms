using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    public class SumNNumbers
    {
        public int NSum(int n)
        {
            int total = 0;

            if (n > 0)
            {
                Console.WriteLine("Enter the values: ");
                int[] arr = new int[n];
                for (var i = 0; i < n; i++)
                {
                    var number = Convert.ToInt32(Console.ReadLine());
                    arr[i] = number;
                }
                foreach (var item in arr)
                {
                    total += item;
                }
            }
          
           
            return total;
        } 
    }
}
