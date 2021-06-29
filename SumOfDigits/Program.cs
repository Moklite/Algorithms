using System;

namespace SumOfDigits
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine("Enter a number to calculate it's factorial: ");
			var number = int.Parse(Console.ReadLine());
			SumOfDigits(number);

		}

		public static void SumOfDigits(int number)
		{
			var sum = 0.0;
			var numberToString = number.ToString();
			foreach (char c in numberToString)
			{
				sum += Convert.ToInt32(c.ToString());
			}

			Console.WriteLine("Sum of digits of " + number + " = " + sum);
		}

		public static void SumOfDigits3()
		{

			int r, n, sum = 0, temp;

			n = int.Parse(Console.ReadLine());

			temp = n;

			while (n > 0)
			{
				r = n % 10;
				sum += r;
				n = n / 10;
			}


			Console.WriteLine(sum);
		}

	}
}
