using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace ArmstrongNumber
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number: ");
			var number = int.Parse(Console.ReadLine());
			if (Armstrong(number))
				Console.WriteLine(number + " - Armstrong number");
			else
				Console.WriteLine(number + " - not an Armstrong number");
		}

		public static bool Armstrong(int number)
		{
			var sum = 0.0;
			var numberToString = number.ToString();
			foreach (char c in numberToString)
			{
				var num = Convert.ToInt32(c.ToString());
				sum += Math.Pow(num, 3);
			}
			var sumToString = sum.ToString();
			if (sumToString == numberToString)
				return true;
			else
				return false;
		}

		public static void Armstrong3()
		{

			int r, n, sum = 0, temp;

			n = int.Parse(Console.ReadLine());

			temp = n;

			while (n > 0)
			{
				r = n % 10;
				sum += (r * r * r);
				n = n / 10;
			}

			if (sum == temp)
				Console.WriteLine("Armstrong number");
			else
				Console.WriteLine("Not an armstrong number");
		}
	}
}
