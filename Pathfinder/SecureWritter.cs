namespace PathfinderLogger
{
    class SecureWritter : ILogger
    {
        private readonly ILogger _logger;
        private readonly DayOfWeek _weekDay;

        public SecureWritter(DayOfWeek weekDay, ILogger logger)
        {
            ArgumentNullException.ThrowIfNull(weekDay);
            ArgumentNullException.ThrowIfNull(logger);

            _logger = logger;
            _weekDay = weekDay;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == _weekDay)
                _logger.WriteError(message);
        }
    }
}
