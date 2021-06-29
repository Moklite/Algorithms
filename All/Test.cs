using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All
{
    public class Test
    {

        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }

        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var all = names1.Union(names2).ToArray();
            return all;
        }

        

    }

    public class TextInput
    {
        public StringBuilder Builder = new StringBuilder();
        public virtual void Add(char c)
        {
            Builder.Append(c);
        }

        public string GetValue()
        {
            return Builder.ToString();
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {

            if (Char.IsDigit(c))
            {
                Builder.Append(c);
            }

        }
    }
}
