using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCSharp
{
    internal class MathCalculator
    {
        static void Main(string[] args)
        {
            SimpleCalc();
        }

        private static void SimpleCalc()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter the first number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operator (+, -, *, /):");
                string op = Console.ReadLine();

                double result = 0;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        break;
                }

                Console.WriteLine("Result: " + result);

                Console.WriteLine("Do you want to continue? (Y/N)");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "N")
                {
                    exit = true;
                }
            }
        }
    }
}
