namespace PathfinderLogger
{
    class GroupingLogger : ILogger
    {
        private ILogger[] _loggers;

        public GroupingLogger(params ILogger[] loggers)
        {
            ValidationLoggersArray(loggers);

            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            foreach (var logger in _loggers)
                logger.WriteError(message);
        }

        private void ValidationLoggersArray(ILogger[] loggers)
        {            
            ArgumentOutOfRangeException.ThrowIfZero(loggers.Length);

            foreach (var logger in loggers)
                ArgumentNullException.ThrowIfNull(logger);
        }
    }
}
