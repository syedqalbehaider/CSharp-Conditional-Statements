using System;

namespace ConsoleApplication4
{
    class Question4
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;

            Console.WriteLine("Enter First Number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator (+, -, *, /)");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (op == '+')
            {
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == '-')
            {
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == '*')
            {
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}