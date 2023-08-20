// See https://aka.ms/new-console-template for more information
using Observer.FirstImplementation;

var subject = new Subject();
var observerA = new FormA();
subject.Attach(observerA);

var observerB = new FormB();
subject.Attach(observerB);

var observerB2 = new FormB();
subject.Attach(observerB2);

subject.ChangeColor("Green");
subject.ChangeColor("Red");

subject.Detach(observerB);

subject.ChangeColor("Blue");
Console.ReadKey();