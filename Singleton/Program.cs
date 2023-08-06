// See https://aka.ms/new-console-template for more information

Console.WriteLine("start FirstImplementation");
Singleton.FirstImplementation.Calculator.Instance.Calc();
Singleton.FirstImplementation.Calculator.Instance.Calc();
Console.WriteLine("end FirstImplementation");

Console.WriteLine("");

Console.WriteLine("start SecondImplementation");
Singleton.SecondImplementation.Calculator.Instance().Calc();
Singleton.SecondImplementation.Calculator.Instance().Calc();
Console.WriteLine("end SecondImplementation");



//Console.WriteLine("start FirstImplementation multithread");
//Parallel.For(0, 10, (int i) =>
//{
//    Singleton.FirstImplementation.Calculator.Instance.Calc();
//});
//Console.WriteLine("end FirstImplementation multithread");


//Console.WriteLine("start SecondImplementation multithread");
//Parallel.For(0, 10, (int i) =>
//{
//    Singleton.SecondImplementation.Calculator.Instance().Calc();
//});
//Console.WriteLine("end SecondImplementation multithread");



Console.ReadKey();
