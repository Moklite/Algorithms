using CoderByte.Challenge;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoderByte
{
    public static class Selection
    {
        public static void SelectedOption(int option)
        {
            switch(option)
            {
                case 1:
                    List<string> input = new List<string> { "apple", "apple", "ball", "cup", "mango", "cup", "banana" };
                    RemoveDuplicate.DistinctValues(input);
                    break;
                case 2:
                    PrimeNumber.PrimeNum();
                    break;
                case 3:
                    FizzBuzzChallenge.FizzBuzz();
                    break;
            }
        }


        public static void DisplayOptions()
        {
            Console.WriteLine("Select the coding challenge you want to execute");
            Console.WriteLine("1: Duplicate Removal \n" +
                "2: Prime number test \n" +
                "3: FizzBuzz \n");

            Console.Write("\nOption: ");
            int option = int.Parse(Console.ReadLine());
            SelectedOption(option);
        }

    }
}
