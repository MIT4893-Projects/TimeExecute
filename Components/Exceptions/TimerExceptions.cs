namespace TimeExecute.Components.Exceptions
{
    /// <summary>
    /// Occurs when stop Timer without started it.
    /// </summary>
    class UnstartedTimerException : Exception
    {
        /// <summary>
        /// Initialize a new instance of UnstartedTimerException.
        /// </summary>
        /// <param name="message">Exception's message.</param>
        public UnstartedTimerException(
            string message = "The timer haven't start yet.") : base(message) { }
    }

    /// <summary>
    /// Occurs when start Timer when it already started.
    /// </summary>
    class StartedTimerException : Exception
    {
        /// <summary>
        /// Initialize a new instance of UnstartedTimerException.
        /// </summary>
        /// <param name="message">Exception's message.</param>
        public StartedTimerException(
            string message = "The timer already started.") : base(message) { }
    }
}
