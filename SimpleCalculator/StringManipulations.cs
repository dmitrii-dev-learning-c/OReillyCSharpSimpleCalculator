using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class StringManipulations
    {

        //internal - only accessable with in the same project (SimpleCalculator project)
        internal static void StringOperations()
        {

            string someText = "Here is some text";
            string someOtherText = "Here is some other text";

            //Comparing strings:
            bool isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);
            Console.WriteLine($"Are the two strings equal? {isEqual}");


            // String concatenation:
            string addedText = someText + " " + someOtherText + "just a little more text";
            string formatedText = string.Format("{0} {1} just a little more text", someText, someOtherText);
               
            Console.WriteLine($"Concatenated text: {addedText}");
            Console.WriteLine($"Formatted text: {formatedText}");

            // String interpolation:
            string interpolatedText = $"{someText} {someOtherText} just a little more text";

            //String length:
            int textLength = someText.Length;
            //Getting a substring (start_From, Numb_of_characters):
            string substring = someText.Substring(8, 3);

            //Creating an Empty string:
            string emptyString = string.Empty;

            //Replacing text:
            string replacedText = someText.Replace("text", "string");
            Console.WriteLine(replacedText);

        }


    }
}
