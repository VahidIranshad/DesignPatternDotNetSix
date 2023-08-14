// See https://aka.ms/new-console-template for more information
var req = new Decorator.FirstImplementation.SimpleRequest();
Console.WriteLine("ReqDisplay:");
req.Display();
var houseReq = new Decorator.FirstImplementation.HouseRequestDecorator(req);
Console.WriteLine("DecoratorDisplay:");
houseReq.Display();


Console.ReadKey();