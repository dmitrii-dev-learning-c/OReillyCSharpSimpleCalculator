using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.exceptionpacakge;

namespace SimpleCalculator
{
    internal class ExceptionExample
    {

        // This method demonstrates how to handle exceptions in C#.
        internal static void ExceptionHandlingExample()
        {
            try
            {   
                Console.WriteLine("Please enter a string to convert to an integer:");
                string input = Console.ReadLine();
                try
                {
                    StringToIntConversion stringToIntConversion = new StringToIntConversion();
                    stringToIntConversion.convert(input);

                }
                catch(Exception ex)
                {
                    Console.WriteLine($"An error occurred with conversion: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
            

            

        }
        
    }
}
