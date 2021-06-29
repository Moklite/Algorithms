using System;

namespace NumberTriangle
{
    class Program
    {
		public static void Main()
		{
			NumberTriangle();
		}

		public static void NumberTriangle()
		{
			int i, j, k, m, n;
			int num = 1;
			n = int.Parse(Console.ReadLine());

			for (i = 1; i <= n; i++)
			{

				for (j = n; j >= i; j--)
					Console.Write(" ");

				for (k = 1; k <= i; k++)
					Console.Write(num++);

				num--;

				for (m = 1; m < i; m++)
					Console.Write(--num);

				Console.WriteLine();

				num = 1;
			}
		}
	}
}
