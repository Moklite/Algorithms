using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Collections;


namespace Palindrome
{		
	public class Program
		{
			public static void Main()
			{
				Console.WriteLine("Enter a number to check if it's a palindrome number or not: ");
				var number = int.Parse(Console.ReadLine());
				if (IsPalindrome(number))
					Console.WriteLine(number + " - Palindrome number");
				else
					Console.WriteLine(number + " - not a Palindrome number");
			}

			public static bool IsPalindrome(int number)
			{

				var numberArray = number.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
				var reverseArray = numberArray.Reverse().ToArray();
				if ( Enumerable.SequenceEqual(reverseArray,numberArray))
					return true;
				else
					return false;
			}


			public static void IsPalindrome3()
			{

				int n, r, temp, sum = 0;
				Console.WriteLine("Enter a number");
				n = int.Parse(Console.ReadLine());
				temp = n;

				while (n > 0)
				{
					r = n % 10;
					sum = (sum * 10) + r;
					n = n / 10;
				}

				if (sum == temp)
					Console.WriteLine("Number is a palindrome");
				else
					Console.WriteLine("Number is not a palindrome");

			}
	}
}
