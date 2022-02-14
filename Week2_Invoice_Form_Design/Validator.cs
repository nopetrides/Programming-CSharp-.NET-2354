using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Invoice_Form
{
    internal static class Validator
    {
        public static bool IsValidDecimal(string toCheck)
        {
            return decimal.TryParse(toCheck, out decimal _);
        }

        public static decimal? TryGetDecimalValueFromString(string toCheck)
        {
            decimal? toReturn = null;

            if (decimal.TryParse(toCheck, out decimal checkedValue))
            {
                toReturn = checkedValue;
            }

            return toReturn;
        }

    }
}
