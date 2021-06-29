using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderByte.Challenge
{
    public static class RemoveDuplicate
    {
        public static void DistinctValues(List<string> arr)
        {
            var result = new List<string>();
            Console.Write("\nOriginal list: ");
            arr.ForEach(x => Console.Write(x + " "));
            result = arr.Distinct().ToList();
            Console.Write("\nDuplicate removed: ");
            result.ForEach(x => Console.Write(x + " "));
            Console.ReadLine();
        }
    }
}
