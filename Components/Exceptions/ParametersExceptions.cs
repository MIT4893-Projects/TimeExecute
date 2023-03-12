using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExecute.Components.Exceptions
{
    class NoCommandParameterToExecuteException : Exception
    {
        /// <summary>
        /// This exception occurs when the program start without any command or application to timing.
        /// </summary>
        /// <param name="message"></param>
        public NoCommandParameterToExecuteException(
            string message = "There aren't any file paths or commands for timing.") : base(message) { }
    }

    class NoCommandArgumentException : Exception
    {
        public NoCommandArgumentException(
            string message = "There aren't any arguments after -a argument " +
                             "which uses for passing arguments to command.") : base(message) { }
    }
}
