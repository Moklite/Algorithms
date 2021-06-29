using System;

namespace All
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the test parenthesis");
            string parentheses = Console.ReadLine();
            Console.WriteLine("Balanced parenthesis: {0}", BalancedParenthesis.ParenthesisCount2(parentheses));

            DecimalToBinary.DecimalToBinay();

            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Test.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia

            Console.WriteLine(Test.Average(2, 1));
            Console.Write("Return a string as character array \nEnter a word or sentence: ");
            var sentence = Console.ReadLine();
            foreach(var item in CharArray.SplitMethod(sentence))
            {
                Console.Write(item + " ");
            }
            
        }
    }
}
