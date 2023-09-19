// See https://aka.ms/new-console-template for more information
using Strategy.FirstImplementation;

Console.WriteLine("1 textlog- 2 dblog");
char input = Console.ReadKey().KeyChar;
ILogStrategy logStrategy = null;
switch (input)
{
    case '1':
        logStrategy = new TextLog();
        break;
    case '2':
        logStrategy = new DBLog();
        break;
    default:
        break;
}
if (logStrategy != null)
{
    new LogMethod(logStrategy).Log(" param");
}
Console.ReadKey();
