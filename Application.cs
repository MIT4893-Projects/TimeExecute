using TimeExecute.Components.Handlers;
using TimeExecute.Components;

namespace TimeExecute
{
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
