using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double convertInputToNumeric(string argStringInput)
        {

            return double.TryParse(argStringInput, out double convertedNumber) 
                ? convertedNumber : throw new ArgumentException("Expected a numeric value");
        }
    }
}
