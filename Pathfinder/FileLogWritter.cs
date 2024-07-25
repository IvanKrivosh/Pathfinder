namespace PathfinderLogger
{
    class FileLogWritter : ILogger
    {
        private string _fileName;

        public FileLogWritter(string fileName)
        {            
            ArgumentException.ThrowIfNullOrEmpty(fileName);

            _fileName = fileName;
        }

        public void WriteError(string message)
        {
            File.AppendAllText(_fileName, $"{message}\n");
        }
    }
}
