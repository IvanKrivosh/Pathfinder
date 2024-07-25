namespace PathfinderLogger
{
    class Pathfinder
    {
        private ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            ArgumentNullException.ThrowIfNull(logger);

            _logger = logger;
        }

        public void Find(string message)
        {
            _logger?.WriteError($"{DateTime.Now}: {message}");
        }
    }
}
