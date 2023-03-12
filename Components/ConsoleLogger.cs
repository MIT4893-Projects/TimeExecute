namespace TimeExecute.Components
{
    /// <summary>
    /// Log errors and warnings messages to the prompt.
    /// </summary>
    static class ConsoleLogger
    {
        /// <summary>
        /// Stores the default foreground color of the prompt when the application starts.
        /// </summary>
        private static readonly ConsoleColor DefaultForegroundColor;

        /// <summary>
        /// Stores the default background color of the prompt when the application starts.
        /// </summary>
        private static readonly ConsoleColor DefaultBackgroundColor;

        /// <summary>
        /// Initialize values for static fields when the application starts.
        /// </summary>
        static ConsoleLogger()
        {
            DefaultForegroundColor = Console.ForegroundColor;
            DefaultBackgroundColor = Console.BackgroundColor;
        }

        /// <summary>
        /// Change the prompt's foreground color.
        /// </summary>
        /// <param name="foreground">The color the prompt's foreground will change to.</param>
        private static void SetForegroundColor(ConsoleColor foreground)
        {
            Console.ForegroundColor = foreground;
        }

        /// <summary>
        /// Change the prompt's background color.
        /// </summary>
        /// <param name="background">The color the prompt's background will change to.</param>
        private static void SetBackgroundColor(ConsoleColor background)
        {
            Console.BackgroundColor = background;
        }

        /// <summary>
        /// Reset prompt's foreground and background colors to default.
        /// </summary>
        private static void ResetColor()
        {
            SetForegroundColor(DefaultForegroundColor);
            SetBackgroundColor(DefaultBackgroundColor);
        }

        /// <summary>
        /// Display an error message into the prompt with specific format.
        /// </summary>
        /// <param name="message">Error message to display.</param>
        public static void ShowError(string message)
        {
            SetForegroundColor(ConsoleColor.Red);
            Console.WriteLine($"ERROR: {message}");
            ResetColor();
        }

        /// <summary>
        /// Display a warning message into the prompt with specific format.
        /// </summary>
        /// <param name="message">Warning message to display.</param>
        public static void ShowWarning(string message)
        {
            SetForegroundColor(ConsoleColor.Yellow);
            Console.WriteLine($"WARNING: {message}");
            ResetColor();
        }
        
        /// <summary>
        /// Display a normal message into the prompt with specific format.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowMessage(string message)
        {
            SetForegroundColor(ConsoleColor.Green);
            Console.WriteLine(message);
            ResetColor();
        }
    }
}
