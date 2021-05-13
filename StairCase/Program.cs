using System;

namespace StairCase
{
    class Program
    {
        static void staircase(int n)
        {
           
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if(j < n - 1 -i)
                    {
                       Console.Write(" ");
                    }
                    else
                    {
                       Console.Write("#");
                    }
                }
                Console.WriteLine();
              
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            //Console.WriteLine("Hello World!");
        }
    }
}
