using System.Text.RegularExpressions;

namespace TimeExecute.Components.Parsers
{
    /// <summary>
    /// Parse and check parameter's string.
    /// </summary>
    static class ParametersParser
    {
        /// <summary>
        /// Check a parameter is option parameter or not.
        /// </summary>
        /// <param name="parameter">Parameter to check.</param>
        /// <returns>The passed parameter is option parameter or not.</returns>
        public static bool IsOptionParameter(string parameter)
        {
            // An option parameter starts with '-' character.
            string pattern = "^[-]{1,2}.{1,}";
            return Regex.Match(parameter, pattern).Success;
        }
    }
}
