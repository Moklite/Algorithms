using System;
using System.Linq;

namespace ReverseNumber
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine("Enter a number to calculate it's factorial: ");
			var number = int.Parse(Console.ReadLine());
			ReverseNumber(number);

		}

		public static void ReverseNumber(int number)
		{

			var numberToString = number.ToString();
			var reversedNumber = numberToString.Reverse().ToList();
			reversedNumber.ForEach(a => Console.Write(Int32.Parse(a.ToString())));
            Console.ReadLine();
		}

		public static void Reverse3()
		{

			int r, n, sum = 0;

			n = int.Parse(Console.ReadLine());


			while (n > 0)
			{
				r = n % 10;
				sum = sum * 10 + r;
				n = n / 10;
			}

			Console.WriteLine(sum);

		}

	}
}
