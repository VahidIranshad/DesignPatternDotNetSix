namespace Strategy.FirstImplementation
{
    internal class DBLog : ILogStrategy
    {
        public void Log(string param)
        {

            Console.WriteLine("DBLog");
        }
    }
}
