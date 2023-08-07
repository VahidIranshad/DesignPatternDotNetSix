// See https://aka.ms/new-console-template for more information
using FactoryMehtod.FirstImplementation;

Console.WriteLine("AdvancedBreakfast");
var advanced = new AdvancedBreakfast();
advanced.GetInfo();

Console.WriteLine("SimpleBreakfast");
var simple = new SimpleBreakfast();
simple.GetInfo();



Console.ReadKey();