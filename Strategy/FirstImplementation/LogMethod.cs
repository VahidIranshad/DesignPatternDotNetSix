namespace Strategy.FirstImplementation
{
    internal class LogMethod
    {
        private readonly ILogStrategy _logStrategy;
        public LogMethod(ILogStrategy logStrategy)
        {
            _logStrategy = logStrategy;
        }
        public void Log(string param)
        {
            _logStrategy.Log(param);
            Console.WriteLine("log" + param);
        }
    }
}
