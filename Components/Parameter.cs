using TimeExecute.Components.Parsers;

namespace TimeExecute.Components
{
    /// <summary>
    /// Represents an application parameter.
    /// </summary>
    class Parameter
    {
        /// <summary>
        /// Get a value whether this Parameter is option parameter.
        /// </summary>
        public readonly bool IsOption = false;

        /// <summary>
        /// Get name of this Parameter.
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Create an application parameter from name.
        /// </summary>
        /// <param name="name">Name of the parameter.</param>
        public Parameter(string name)
        {
            IsOption = ParametersParser.IsOptionParameter(name);
            Name = name;
        }
    }
}
