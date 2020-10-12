using System;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeApp = false;

            Console.WriteLine("Console calculator in c#\r");
            Console.WriteLine("------------------------\n");

            Calculator calculator = new Calculator();
            while (!closeApp)
            {
                string nInput1 = "";
                string nInput2 = "";
                double result = 0;

                Console.Write("Enter first number and then press Enter Key: ");
                nInput1 = Console.ReadLine();

                double cleanN1 = 0;
                while (!double.TryParse(nInput1, out cleanN1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    nInput1 = Console.ReadLine();
                }

                Console.Write("Enter second number and then press Enter Key: ");
                nInput2 = Console.ReadLine();

                double cleanN2 = 0;
                while (!double.TryParse(nInput2, out cleanN2))
                {
                    Console.Write("This is not a valid input. Please enter an integer value: ");
                    nInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an mathematical operator from the list below:");
                Console.WriteLine("\tadd - Addition");
                Console.WriteLine("\tsub - Subtraction");
                Console.WriteLine("\tmul - Multiply");
                Console.WriteLine("\tdiv - Division");
                Console.WriteLine("Type your option");

                string opr = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleanN1, cleanN2, opr);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("It will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Answer is: {0:0.##}\n", result);
                }
                catch (Exception exp)
                {
                    Console.WriteLine("An exception occurred while doing to do the mathematical opration.\n - Details: " + exp.Message);
                }

                Console.WriteLine("-------------------------\n");

                Console.Write("Press 'c' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "c") closeApp = true;

                Console.WriteLine("\n");
            }
            calculator.Finish();
            return;
        }
    }
}