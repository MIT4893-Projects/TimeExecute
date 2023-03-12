using System.Diagnostics;
using TimeExecute.Components.Exceptions;

namespace TimeExecute.Components.Handlers
{
    class ApplicationParametersHandler
    {
        private readonly List<Parameter> Parameters = new();

        public ApplicationParametersHandler(string[] parameters)
        {
            if (parameters.Length == 0)
                throw new NoCommandParameterToExecuteException();

            ParseParameters(parameters);
        }

        private void ParseParameters(string[] parameters)
        {
            for (int idx = 0; idx < parameters.Length; ++idx)
            {
                string parameter = parameters[idx];

                // "-a" argument means the very next argument after it is a argument
                // store all arguments for command to execute.
                if (parameter == "-a")
                {
                    if (idx == parameters.Length - 1)
                        throw new NoCommandArgumentException();

                    string fullParameter = parameter + parameters[++idx];
                    Parameters.Add(new(fullParameter));
                    continue;
                }

                Parameters.Add(new(parameter));
            }
        }

        public async Task StartCommand()
        {
            foreach (Parameter parameter in Parameters)
            {
                if (!parameter.IsOption)
                {
                    string command = parameter.Name;

                    Process process = new()
                    {
                        StartInfo = new(command) { UseShellExecute = false }
                    };
                    process.Start();
                    await process.WaitForExitAsync();

                    Console.WriteLine();
                    ConsoleLogger.ShowMessage($"Exit code: {process.ExitCode}");
                }
            }
        }
    }
}
