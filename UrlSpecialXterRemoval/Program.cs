using System;
using System.Linq;

namespace UrlSpecialXterRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipherText = "bhs~opsje284289_fkfjd";
            Console.WriteLine("Original cipherText = {0}", cipherText);
            var SpecialExist = cipherText.Contains("_");

            int count = cipherText.Count(f => f == '_');

            if (count != 0)
            {
                foreach (char ch in cipherText)
                {
                    if (ch == '_')
                    {
                        cipherText = cipherText.Replace("_", "+");
                    }
                }
            }

            int countSlash = cipherText.Count(f => f == '~');

            if (countSlash != 0)
            {
                foreach (char ch in cipherText)
                {
                    if (ch == '~')
                    {
                        cipherText = cipherText.Replace("~", "/");
                    }
                }
            }

            Console.WriteLine("New cipherText = {0}", cipherText);
        }
    }
}
