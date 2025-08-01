using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//importing the String Manipulations class:
using static SimpleCalculator.StringManipulations;

using static SimpleCalculator.ExceptionExample;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Running the Strings Manipulations method:
            Console.WriteLine("Short String Manipulations Example!");
            StringOperations();
            Console.WriteLine("--------------------------------------------------");

            //Running the ExceptionExample method:
            Console.WriteLine("Exception Handling Example!");
            ExceptionHandlingExample();
            Console.WriteLine("--------------------------------------------------");


            //SIMPLE CALCULATOR EXAMPLE:
            Console.WriteLine("Welcome to the Simple Calculator!");
            try
            {
                //Take in the user input and convert it to an integer:
                InputConverter inputConverter = new InputConverter();

                //Takes care of the calculation logic:
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //Prompt the user for input:
                Console.Write("Enter the first number: ");
                double firstNumber = inputConverter.convertInputToNumeric(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNumber = inputConverter.convertInputToNumeric(Console.ReadLine());
                Console.Write("Enter the operation (add, subtract, multiply, divide): ");
                string operation = Console.ReadLine();

                double result = calculatorEngine.calculate(firstNumber, secondNumber, operation);
                Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is: {result}");
                
            }
            catch (Exception ex)
            {
                //TODO log the exception:
                Console.WriteLine(ex.Message);
            }
            //SIMPLE CALCULATOR EXAMPLE END




        }
    }
}
