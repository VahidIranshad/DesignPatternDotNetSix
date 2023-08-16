// See https://aka.ms/new-console-template for more information

using Prototype.SecondImplementation;

Console.WriteLine("start FirstImplementation");
var carFirstImplementation = new Prototype.FirstImplementation.Car() { Brand = "X", Model = "1"};
var carCloneFirstImplementation = carFirstImplementation.Clone() as Prototype.FirstImplementation.Car;
carCloneFirstImplementation.Brand = "Y";
carCloneFirstImplementation.Model = "2";
carFirstImplementation.GetInfo();
carCloneFirstImplementation.GetInfo();
Console.WriteLine("end FirstImplementation");

Console.WriteLine("");

Console.WriteLine("start SecondImplementation ** this do not use the pattern. this is just a way to copy an object");
var carSecondImplementation = new Prototype.SecondImplementation.Car() { Brand = "a", Model = "3" };
var carCloneSecondImplementation = carSecondImplementation.DeepClone();
carCloneSecondImplementation.Brand = "b";
carCloneSecondImplementation.Model = "4";
carSecondImplementation.GetInfo();
carCloneSecondImplementation.GetInfo();
Console.WriteLine("end SecondImplementation");
Console.ReadKey();
