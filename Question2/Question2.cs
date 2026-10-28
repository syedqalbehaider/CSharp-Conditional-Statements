using System;

namespace ConsoleApplication2
{
    class Question2
    {
        static void Main(string[] args)
        {
            double amount;
            double discountPercentage;
            double discountAmount;
            double finalAmount;

            Console.WriteLine("Enter Purchase Amount");
            amount = Convert.ToDouble(Console.ReadLine());

            if (amount >= 5000)
            {
                discountPercentage = 20;
            }
            else if (amount >= 2000 && amount < 5000)
            {
                discountPercentage = 10;
            }
            else
            {
                discountPercentage = 0;
            }

            discountAmount = (amount * discountPercentage) / 100;
            finalAmount = amount - discountAmount;

            Console.WriteLine("The discount percentage: " + discountPercentage + "%");
            Console.WriteLine("The discount amount: " + discountAmount);
            Console.WriteLine("The final payable amount: " + finalAmount);
        }
    }
}