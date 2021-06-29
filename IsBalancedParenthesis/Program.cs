using System;

namespace IsBalancedParenthesis
{
    class Program
    {
		public static void Main()
		{
			Stack stack = new Stack();
			bool d = true;

			Console.WriteLine("Enter the parenthesis");
			var parenthesis = Console.ReadLine();

			if ((parenthesis.Length % 2) == 1)
				d = false;

			foreach (char c in parenthesis)
			{
				if (c == '(')
					stack.Push(c);

				if (c == ')')
				{

                    if (stack.isEmpty())
						d = false;

					var top = stack.Pop();


					if (top == '(' && c != ')')
					{
						d = false;
					}

				}

			}


			if (stack.isEmpty() && d)
				Console.WriteLine("balanced parenthesis");
			else
				Console.WriteLine("Not a balanced parenthesis");
			Console.ReadLine();
		}


		public class Stack
		{

			static readonly int max = 1000;
			int top;
			int[] stack = new int[max];

            public Stack()
            {
                top = -1;
            }

            public bool isEmpty()
			{
				return (top < 0);
			}

			public bool Push(int data)
			{
				stack[++top] = data;
				return true;
			}

			public int Pop()
			{

                if (!isEmpty())
                {
					int value = stack[top--];
					return value;
				}
				else
					return -1;
			}

		}
	}
}
