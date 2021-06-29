using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderByte.Challenge
{
    public static class FizzBuzzChallenge
    {

        public static void FizzBuzz()
        {
            var result = new List<string>();
            for(var i =1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            result.ForEach(x => Console.Write(x + " "));
            Console.ReadLine();
        }

        public static void FizzBuzz2()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz ");
                else if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if (i % 5 == 0)
                    Console.Write("Buzz ");
                else
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }

    }
}
