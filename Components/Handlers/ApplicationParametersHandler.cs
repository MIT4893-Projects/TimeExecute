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
            foreach (string parameter in parameters)
                Parameters.Add(new(parameter));
        }
    }
}
