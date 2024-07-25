namespace PathfinderLogger
{
    class SecureWritter : ILogger
    {
        private ILogger[] _loggers;
        private DayOfWeek _weekDay;

        public SecureWritter(DayOfWeek weekDay, params ILogger[] loggers)
        {
            ArgumentNullException.ThrowIfNull(weekDay);            
            ArgumentOutOfRangeException.ThrowIfZero(loggers.Length);            

            foreach (var logger in loggers)
                ArgumentNullException.ThrowIfNull(logger);

            _loggers = loggers;
            _weekDay = weekDay;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == _weekDay)
                foreach (var logger in _loggers)
                    logger.WriteError(message);
        }
    }
}
