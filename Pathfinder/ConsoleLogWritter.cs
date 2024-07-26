namespace PathfinderLogger
{
    class ConsoleLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public ConsoleLogWritter(ILogger logger = null)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            Console.WriteLine(message);

            if (_logger != null)
                _logger.WriteError(message);
        }
    }
}
