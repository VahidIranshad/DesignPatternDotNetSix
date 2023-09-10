// See https://aka.ms/new-console-template for more information
using Visitor.FirstImplementation;

var modelA = new ModelA();
var modelB = new ModelB();

var visitorA = new VisitorA();
var visitorB = new VisitorB();

modelA.Accept(visitorA);
modelB.Accept(visitorA);
modelA.Accept(visitorB);
modelB.Accept(visitorB);
Console.ReadKey();
