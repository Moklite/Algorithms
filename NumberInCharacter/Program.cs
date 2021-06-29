using System;

namespace NumberInCharacter
{
	class Program
	{
		public static void Main()
		{
			NumberInCharacter2();
			NumberInCharacter();

		}

		public static void NumberInCharacter()
		{
			int n, r, sum = 0;
			n = int.Parse(Console.ReadLine());

			while (n > 0)
			{
				r = n % 10;
				sum = sum * 10 + r;
				n /= 10;
			}
			Console.WriteLine(sum);
			n = sum;

			while (n > 0)
			{
				r = n % 10;
				switch (r)
				{
					case 1:
						Console.Write(" one");
						break;
					case 2:
						Console.Write(" two");
						break;
					case 3:
						Console.Write(" three");
						break;
					case 4:
						Console.Write(" four");
						break;
					case 5:
						Console.Write(" five");
						break;
					case 6:
						Console.Write(" six");
						break;
					case 7:
						Console.Write(" seven");
						break;
					case 8:
						Console.Write(" eight");
						break;
					case 9:
						Console.Write(" nine");
						break;
					case 0:
						Console.Write(" zero");
						break;
					default:
						Console.Write(" eight");
						break;
				}
				n /= 10;
			}



		}


		public static void NumberInCharacter2()
		{
			Console.Write("Enter string:");
			var value = Console.ReadLine();

			int i,r;
			int n = value.Length;
			int firstValue = (int)'0';

			
			for (i = 0; i < n; i++)
			{
				r = (int)value[i] - firstValue;
				switch (r)
				{
					case 1:
						Console.Write(" one");
						break;
					case 2:
						Console.Write(" two");
						break;
					case 3:
						Console.Write(" three");
						break;
					case 4:
						Console.Write(" four");
						break;
					case 5:
						Console.Write(" five");
						break;
					case 6:
						Console.Write(" six");
						break;
					case 7:
						Console.Write(" seven");
						break;
					case 8:
						Console.Write(" eight");
						break;
					case 9:
						Console.Write(" nine");
						break;
					case 0:
						Console.Write(" zero");
						break;
					default:
						Console.Write(" eight");
						break;
				}

				
			}

			Console.ReadLine();
		}
	}
}
