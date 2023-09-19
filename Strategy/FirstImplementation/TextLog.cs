namespace Strategy.FirstImplementation
{
    internal class TextLog : ILogStrategy
    {
        public void Log(string param)
        {
            Console.WriteLine("TextLog");
        }
    }
}
