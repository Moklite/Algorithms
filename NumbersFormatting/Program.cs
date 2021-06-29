using System;

namespace NumbersFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Formatting");
            double number = 1234.56;

            Console.WriteLine(string.Format("{0:0.000}", number));
            //string.Format("{0:0.000}", number);     // 1234.560

            Console.WriteLine(string.Format("{0:#,0.00}", number));
            //string.Format("{0:#,0.00}", number);     // 1,234.56 

            Console.WriteLine(string.Format("{0:#,0.####}", number));
            //string.Format("{0:#,0.####}", number);   // 1,234.56

            // Thousand separator and number scaling    
            Console.WriteLine(string.Format("{0:#,0}", 123000000));
            //string.Format("{0:#,0}", 123000000);     // 123,000,000

            Console.WriteLine(string.Format("{0:#,0, K}", 123000000));
            //string.Format("{0:#,0, K}", 123000000);  // 123,000 K

            Console.WriteLine(string.Format("{0:#,0,, M}", 123000000));
            //string.Format("{0:#,0,, M}", 123000000); // 123 M
        }
    }
}
