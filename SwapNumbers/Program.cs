using System;

namespace SwapNumbers
{
    class Program
    {
		public static void Main()
		{
			SwapNumber();

		}

		public static void SwapNumber()
		{
			//swap 2 numbers without a third variable
			Console.WriteLine("Enter 2 numbers: ");
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			Console.WriteLine("Before swap a= " + a + " b= " + b);
			// * and /
            a = a * b;
            b = a / b;
            a = a / b;
            //or + and -
			//a = a + b;
			//b = a - b;
			//a = a - b;
			Console.Write("After swap a= " + a + " b= " + b);

		}
	}
}
