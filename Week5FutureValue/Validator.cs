using System.Windows.Forms;

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
            if (parsedInt > int.MaxValue / 12)
            {
                MessageBox.Show("The number is too big! Please choose a smaller timescale.",
                "Number unsupported",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                parseSuccess = false;
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
    }
}
