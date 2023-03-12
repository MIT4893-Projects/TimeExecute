using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeExecute.Components.Exceptions
{
    class UnstartedTimerException : Exception
    {
        /// <summary>
        /// This Exception occurs when stop Timer without started it.
        /// </summary>
        public UnstartedTimerException(
            string message = "The timer haven't start yet.") : base(message) { }
    }

    class StartedTimerException : Exception
    {
        /// <summary>
        /// This Exception occurs when start Timer whether it have been started.
        /// </summary>
        public StartedTimerException(
            string message = "The timer already started.") : base(message) { }
    }
}
