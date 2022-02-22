using System;
using System.Collections.Generic;
using System.Text;

namespace Week5FutureValue
{
    public class ErrorHandler
    {
        /// <summary>
        /// throws an exception message
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <exception cref="Exception"></exception>
        public static void ThrowErrorMessage(string errorMessage)
        {
            throw new Exception(errorMessage);
        }

        /// <summary>
        /// Generic Error window that takes in arguements about what failed to parse
        /// </summary>
        /// <param name="stringToParse"></param>
        /// <param name="fieldName"></param>
        /// <param name="parseType"></param>
        public static void ThrowParseError(string stringToParse, string fieldName, string parseType)
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
            throw new Exception(errorString);
        }
    }
}
