using System;

namespace ConsoleApplication3
{
    class Question3
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}