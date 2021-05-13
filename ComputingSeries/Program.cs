using System;
using System.Linq;

namespace ComputingSeries
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i=0; i<array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static int Factorial(int[] array)
        {
            int sum = 1;
            foreach(var item in array)
            {
                sum *= item;
            }
            return sum;
        }

        static int FibonacciAt(int index)
        {
            int first = 0;
            int second = 1;
            for (int i = 0; i < index; i++)
            {
                int temp = first;
                first = second;
                second = temp + first;
            }
            return first;
        }

        static int[] CreateFibonacci(int length)
        {
            int[] fibo = new int[length];
            for(int i=0; i<length; i++)
            {
                fibo[i] = FibonacciAt(i);
            }
            return fibo;
        }

        static void Main(string[] args)
        {
           
            int[] numbers = { 1,2,3,4,5,6,7,8,9};
            int summed = Sum(numbers);
            Console.WriteLine("That's the sum of the numbers " + summed);
            Console.WriteLine("Factorial of {0} is: {1}", numbers.Last(), Factorial(numbers));

            Console.WriteLine("Fibonacci Series");

            foreach(var item in CreateFibonacci(20))
            {
                //0,1,1,2,3,5,8,13,21,34,...
                Console.Write(item + ", ");
            }
            Console.ReadLine();
        }
    }
}
