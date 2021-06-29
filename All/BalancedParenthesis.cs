using System;

namespace All
{
	//class BalancedParenthesis
	public class BalancedParenthesis
	{
		
		public static bool ParenthesisCount(string parentheses)
		{
			var countLeft = 0;
			var countRight = 0;
			var result = true;
			foreach (char c in parentheses)
			{
				if (c == '(')
					countLeft++;
				else if (c == ')')
					countRight++;
			}

			result = (countLeft == countRight) ? true : false;

			return result;
		}

		public static bool ParenthesisCount2(string parentheses)
		{


			if (parentheses.Length % 2 == 1)
			{
				return false;
			}

            Stack stackedParenthesis = new Stack();
            //var stackedParenthesis = new Stack<char>();
			//var splitInput = parentheses.ToCharArray();
			foreach (char c in parentheses)
			{
				if (c == '(')
					stackedParenthesis.Push(c);

				if (c == ')')
				{
					if (stackedParenthesis.IsEmpty())
					{
						return false;
					}
					var top = stackedParenthesis.Pop();
					if ((top == '(' && c != ')'))
					{
						return false;
					}
				}

			}
			// the expression is balanced only when the stack is empty at this point
			return stackedParenthesis.IsEmpty();
		}

		

		internal class Stack
        {
            static readonly int MAX = 1000;
            int top;
            int[] stack = new int[MAX];

            public bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            internal bool Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }

            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                    Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }

            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are :");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }

    }
}


					
