using System;

namespace FiftyQuestions
{
    class Program
    {
        //Q-1. What will be the output of the following code snippet: 6,12
        public static void QuesOne()
        {
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(11.5));
            Console.WriteLine(Math.Ceiling(6.5));
            Console.WriteLine(Math.Ceiling(11.5));
        }

        //Q-2. What will be the output of the following code snippet:  IndexOutOfRangeException
        public static void QuesTwo()
        {
            int[] i = new int[0];
            Console.WriteLine(i[0]);
        }
        
        //Q-3. What will be the output of the following code snippet:  IndexOutOfRangeException
        public static void QuesThree()
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
        }
        //Q-3. What will be the output of the following code snippet:  IndexOutOfRangeException
        public static void QuesFour()
        {
            #if (!pi)
                Console.WriteLine("i");
            #else
                Console.WriteLine("PI undefined");
            #endif
            Console.WriteLine("ok");
            Console.ReadLine();
        }


        

        static void Main(string[] args)
        {
            Console.WriteLine("one: ");
            QuesOne();

            Console.WriteLine("two: ");
            //QuesTwo();         
            
            Console.WriteLine("three: ");
            QuesThree(); 
            
            Console.WriteLine("four: ");
            QuesFour();


            Console.WriteLine("Hello World!");
        }
    }
}
