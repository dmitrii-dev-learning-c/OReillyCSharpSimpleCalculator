using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.exceptionpacakge
{
    internal class StringToIntConversion
    {
        public int convert(string input)
        {
            try
            {
                int convertedInput;
                bool isConvertedSuccesfully = int.TryParse(input, out convertedInput);

                if (!isConvertedSuccesfully)
                {
                    throw new Exception("Conversion was not successful!");

                }
                return convertedInput;
            }
            catch (Exception ex)
            {
                throw;
                
            }
        }
    }
}
