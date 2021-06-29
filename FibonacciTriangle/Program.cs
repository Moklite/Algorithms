using System;

namespace FibonacciTriangle
{
    class Program
    {
		public static void Main()
		{

			FibonacciTriangle();

		}

		public static void FibonacciTriangle()
		{
			int i, j, k, n, n1 = 1, n2 = 1, n3;
			int num = 1;
			n = int.Parse(Console.ReadLine());


			for (i = 1; i <= n; i++)
			{

				if (i == 1)
					Console.Write(n1 + " ");
				else if (i == 2)
				{
					for (j = 1; j <= i; j++)
						Console.Write(n2 + " ");
				}
				else
				{
					Console.Write(n1 + " " + n2 + " ");
					for (k = 1; k <= i; k++)
					{
						n3 = n1 + n2;
						Console.Write(n3 + " ");
						n1 = n2;
						n2 = n3;
					}

				}

				Console.WriteLine();

				n1 = num;
				n2 = num;

			}
		}
	}
}
