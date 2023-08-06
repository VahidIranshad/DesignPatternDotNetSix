// See https://aka.ms/new-console-template for more information

Console.WriteLine("start FirstImplementation");
var calculateFirstImplementation = Singleton.FirstImplementation.Calculator.Instance;
calculateFirstImplementation.Calc();
calculateFirstImplementation.Calc();
calculateFirstImplementation.Calc();
calculateFirstImplementation.Calc();
Console.WriteLine("end FirstImplementation");

Console.WriteLine("start SecondImplementation");
var calculateSecondImplementation = Singleton.SecondImplementation.Calculator.Instance();
calculateSecondImplementation.Calc();
calculateSecondImplementation.Calc();
calculateSecondImplementation.Calc();
calculateSecondImplementation.Calc();
Console.WriteLine("end SecondImplementation");


Console.ReadKey();
