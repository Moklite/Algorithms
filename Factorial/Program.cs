using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Factorial
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number to calculate it's factorial: ");
			var number = int.Parse(Console.ReadLine());
			Console.WriteLine("Factorial of {0} = {1}", number, Factorial(number));
		}

		public static int Factorial(int number)
		{
			var factorial = 1;
			for (var i = 1; i <= number; i++)
				factorial *= i;
			return factorial;
		}

		public static void Factorial2()
		{

			int i, n, fact = 1;

			n = int.Parse(Console.ReadLine());

			for (i = 1; i <= n; i++)
				fact *= i;

			Console.WriteLine(fact);
		}
	}
}
