using TimeExecute.Components;
using TimeExecute.Components.Handlers;

namespace TimeExecute
{
    /// <summary>
    /// Program's controller class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Timer object to measure execute time.
        /// </summary>
        private readonly Components.Timer ExecuteTimer = new();

        /// <summary>
        /// Application's parameters handler.
        /// </summary>
        private readonly ApplicationParametersHandler ParametersHandler;

        public Program(string[] args)
        {
            ParametersHandler = new(args);

            if (args.Contains("--debugwait2"))
            {
                const string debugWarningMessage =
                    "You're running a debug session with sleep time: 2 second.";
                ConsoleLogger.ShowWarning(debugWarningMessage);

                ExecuteTimer.StartTimer();
                Thread.Sleep(2000);
                Console.WriteLine(TimeSpanConverter.ToSecond(ExecuteTimer.StopTimer()));
            }

            Timing();
        }

        private void Timing()
        {
            ExecuteTimer.StartTimer();
            ParametersHandler.StartCommand().Wait();
            TimeSpan executeTime = ExecuteTimer.StopTimer();

            ConsoleLogger.ShowMessage($"Execution time: {TimeSpanConverter.ToSecond(executeTime)}s");
        }
    }
}