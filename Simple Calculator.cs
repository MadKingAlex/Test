using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The user puts their two in here
            Console.WriteLine("Enter your first number:");
           string inputNumber1 = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
           string inputNumber2 = Console.ReadLine();
           
            //We need to convert string to double because yes and we want the precision because decimal numbers
            double number1 = Convert.ToInt64(inputNumber1);
            double number2 = Convert.ToInt64(inputNumber2);

            //Now is time for da math
            Console.WriteLine("Sum: " + (number1 + number2));
            Console.WriteLine("Difference: " + (number1 - number2));
            Console.WriteLine("Product: " + (number1 * number2));
            Console.WriteLine("Quotient: " + (number1 / number2));
            
                Console.ReadKey();
        }
    }
}
