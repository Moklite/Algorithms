using System;
using System.Collections.Generic;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            var type = a.GetType();
            var type2 = a.GetTypeCode();
            Console.WriteLine("Type of a: {0}, {1}", type, type2);

            var dict = new Dictionary<int, int>();
            dict.Add(1, 5);
            dict.Add(2, 6);
            dict.Add(3, 7);
            dict.Add(4, 8);
            dict.Add(5, 9);
            

            foreach(var d in dict)
            {
                if(d.Key != 5)
                    Console.WriteLine("{0}\t{1}", d.Key, d.Value);
            }
        }
    }
}
