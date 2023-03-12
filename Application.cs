using TimeExecute.Components;

namespace TimeExecute
{
    /// <summary>
    /// Main class of application.
    /// </summary>
    class Application
    {
        /// <summary>
        /// This function will invoke when the program starts.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Program _ = new(args);
            }
            catch (Exception exception)
            {
                ConsoleLogger.ShowError(exception.Message);
            }
        }
    }
}
