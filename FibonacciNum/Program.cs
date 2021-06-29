using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Program
{
	public static void Main()
	{
		Fibonacci();

		Console.Write("Enter the length of the Fibonacci Series: ");
		var number = int.Parse(Console.ReadLine());

		var fiboNumbers = FibonacciWithoutRecursion(number);
		fiboNumbers.ForEach(a => Console.Write(a + " "));

        Console.WriteLine();

		for (int i = 0; i < number; i++)
		{
			Console.Write("{0} ", FibonacciSeriesRecursion(i));
		}
		Console.ReadLine();

	}


	public static void Fibonacci()
	{
		int a = 0;
		int b = 1;
		int c;
		var n = int.Parse(Console.ReadLine());
		Console.Write(a + " " + b + " ");
		for (var i = 2; i < n; i++)
		{
			c = a + b;
			Console.Write(c + " ");
			a = b;
			b = c;
		}
	}

	public static int FibonacciSeriesRecursion(int n)
	{
		if (n == 0) return 0; //To return the first Fibonacci number   
		if (n == 1) return 1; //To return the second Fibonacci number   
		return FibonacciSeriesRecursion(n - 1) + FibonacciSeriesRecursion(n - 2);
	}

	public static List<int> FibonacciWithoutRecursion(int number)
	{
		var fiboNumbers = new List<int>();
		var n1 = 0;
		var n2 = 1;
		int n3;
		fiboNumbers.Add(n1);
		fiboNumbers.Add(n2);
		//Console.Write(n1 + "," + n2 + ",");
		for (var i = 2; i < number; i++)
		{

			n3 = n1 + n2;
			fiboNumbers.Add(n3);
			//Console.Write(n3 + ",");
			n1 = n2;
			n2 = n3;
		}
		return fiboNumbers;
	}
}