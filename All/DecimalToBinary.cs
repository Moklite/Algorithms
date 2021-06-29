using System;
using System.Collections.Generic;
using System.Text;

namespace All
{
    public class DecimalToBinary
    {
		public static void DecimalToBinay()
		{
			Console.WriteLine("Enter a decimal number: ");
			var n = int.Parse(Console.ReadLine());
			var arr = new List<int>();

			Console.WriteLine("Method 1: ");
			var binary = Convert.ToString(n, 2);
			Console.WriteLine(binary);

			Console.WriteLine("Method 2: ");
			for (var i=0; n>0; i++)
            {
				arr.Add(n % 2);
				n = n / 2;
            }

			for(var j=arr.Count-1; j>=0; j--)
            {
				Console.Write(arr[j]);
			}
            Console.WriteLine();

		}

		public static void DecimalToBinary3()
		{
			int n, i;
			int[] a = new int[50];
			n = int.Parse(Console.ReadLine());

			for (i = 0; n > 0; i++)
			{
				a[i] = n % 2;
				n /= 2;
			}

			for (i = i - 1; i >= 0; i--)
			{
				Console.Write(a[i]);
			}


		}

		public static void DecimalToBinary4()
		{
			int n, i, temp;
			int[] a = new int[50];
			n = int.Parse(Console.ReadLine());

			for (i = 0; n > 0; i++)
			{
				a[i] = n % 10;
				n /= 10;
			}

			temp = i;
			for (i = 0; i < temp; i++)
			{
				Console.Write(a[i]);
			}


		}

	}
}
