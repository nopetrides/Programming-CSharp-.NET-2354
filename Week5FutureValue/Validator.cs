using System.Windows.Forms;
using System;

namespace Week5FutureValue
{
    /// <summary>
    /// Validation class to be used for type parsing
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Wrapper for decimal.TryParse
        /// Shows error on failure
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="parsedDecimal"></param>
        /// <returns></returns>
        public static bool TryParseDecimal(string stringToParse, string fieldName, out decimal parsedDecimal)
        {
            bool parseSuccess = decimal.TryParse(stringToParse, out parsedDecimal);
            if (!parseSuccess)
            {
                ShowParseError(stringToParse, fieldName, "decimal");
            }
            return parseSuccess;
        }

        /// <summary>
        /// Wrapper for int.TryParse
        /// Shows error on failure
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="parsedInt"></param>
        /// <returns></returns>
        public static bool TryParseInt(string stringToParse, string fieldName, out int parsedInt)
        {
            bool parseSuccess = int.TryParse(stringToParse, out parsedInt);
            if (!parseSuccess)
            {
                ShowParseError(stringToParse, fieldName, "int");
            }
            return parseSuccess;
        }

        /// <summary>
        /// Validates the user entry from Years To Invest
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="parsedInt"></param>
        /// <returns></returns>
        public static bool ValidateYearsToInvest(string stringToParse, string fieldName, out int parsedInt)
        {
            // Do we want to force the user to invest? If so, remove this
            if (string.IsNullOrEmpty(stringToParse))
            {
                parsedInt = 1;
            }
            bool parseSuccess = TryParseInt(stringToParse, fieldName, out parsedInt);
            if (parseSuccess)
            {
                if (parsedInt > int.MaxValue / 12)
                {
                    MessageBox.Show("The number is too big! Please choose a smaller timescale.",
                    "Number unsupported",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    parseSuccess = false;
                }
            }
            return parseSuccess;
        }

        /// <summary>
        /// Generic Error window that takes in arguements about what failed to parse
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="parseType"></param>
        private static void ShowParseError(string stringToParse, string fieldName, string parseType)
        {
            string errorString;
            if (string.IsNullOrEmpty(stringToParse))
            {
                errorString = $"Please enter a value in the text box {fieldName}";
            }
            else
            {
                errorString = $"Could not parse into {parseType}: \"{stringToParse}\"";
            }
            MessageBox.Show(errorString,
                "You are a big dumb.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Wrapper for Enum.TryParse
        /// Parsese the FrmFutureValue.InterestType
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="interestType"></param>
        /// <returns></returns>
        internal static bool TryParseInterestType(string stringToParse, string fieldName, out FrmFutureValue.InterestType interestType)
        {
            bool parseSuccess = false;
            if (string.IsNullOrEmpty(stringToParse))
            {
                ShowParseError(stringToParse, fieldName, "FrmFutureValue.InterestType");
                interestType = FrmFutureValue.InterestType.None;
            }
            else if (stringToParse.Length > 1)
            { 
                ShowParseError(stringToParse, fieldName, "FrmFutureValue.InterestType");
                interestType = FrmFutureValue.InterestType.None;
            }
            else 
            { 
                char characterToParse = stringToParse[0];
                interestType = (FrmFutureValue.InterestType)characterToParse;
                if (interestType == FrmFutureValue.InterestType.Fixed || interestType == FrmFutureValue.InterestType.Compound)
                {
                    parseSuccess = true;
                }
                else
                {
                    ShowParseError(stringToParse, fieldName, "FrmFutureValue.InterestType");
                }
            }
            return parseSuccess;
        }
    }
}
