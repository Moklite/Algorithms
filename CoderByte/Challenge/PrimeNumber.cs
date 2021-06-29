using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderByte.Challenge
{
    public class PrimeNumber
    {

        public static void PrimeNum()
        {
            PrimeNumber prime = new PrimeNumber();
            Console.Write("\nEnter a number to check if it is a prime number: ");
            int number = int.Parse(Console.ReadLine());

            //IsPrime();

            //if (IsPrime2(number)) // IsPrime and IsPrime2 are both working
            if (prime.IsPrime3(number))
                Console.WriteLine(number + " is a prime number");
            else
                Console.WriteLine(number + " is not a prime number");
        }

        private bool IsPrime3(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit
            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;
        }

        static bool IsPrime2(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0)
                                 .SequenceEqual(new[] { 1, n });
            }
            return false;
        }

        public static void IsPrime()
        {
            int n=0,len, j;
            string m;
            bool d = true;
            //n = int.Parse(Console.ReadLine());
            m = Console.ReadLine();

            for(j=0; j<m.Length; j++)
            {
                n = n * 10 + m[j] - (int)'0';
            }

            len = n / 2;

            if (n == 1)
                d = false;

            else if (n == 2)
                d = true;

            else if (n > 2)
            {
                for (int i = 2; i < len; ++i)
                {
                    if (n % i == 0)
                    {
                        d = false;
                        break;
                    }
                       
                }
            }

            else
            {
                d = false;
            }

            if (d)
                Console.WriteLine("number is prime");
            else
                Console.WriteLine("number is not prime");


        }
    }
}
