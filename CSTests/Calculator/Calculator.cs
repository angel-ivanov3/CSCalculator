using System;

namespace CSTests
{
    class Calculator
    {

        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an operation symbol (+,-,*,/): ");
            string operationSymbol = Console.ReadLine();

            Calculate(num1, num2, operationSymbol);
        }

        static void Calculate(int num1, int num2, string operationSymbol)
        {
            int result;
            switch (operationSymbol)
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
                    Console.WriteLine("Invalid operation symbol! Try again.");
                    return;
            }
            Console.WriteLine(num1 + " " + operationSymbol + " " + num2 + " = " + result);
        }

    }
}
