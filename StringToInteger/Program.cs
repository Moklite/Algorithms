using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter string:");
            var value = Console.ReadLine();

            Console.Write("Converted to number: ");
            ConvertToInt(value);

            Console.ReadLine();
        }


        public static void ConvertToInt(string value)
        {

            int i, num=0;
            int n = value.Length;
            int firstValue = (int)'0';

            for (i=0; i<n; i++)
            {
                num = (num * 10) + (int)value[i] - firstValue;
            }

            Console.WriteLine(num); 
        }


        // convert string to integer array

        public static void Convert2()
        {

            int len, counter = 0;
            int firstValue = (int)'0';
            Console.Write("Enter string:");
            var value = Console.ReadLine();
            len = value.Length;
            int[] result = new int[len];

            Console.Write("Converted to number: ");
            foreach (char c in value)
            {
                result[counter] = (int)c - firstValue;
                Console.Write(result[counter]);
                counter++;
            }
        }


    }
}
