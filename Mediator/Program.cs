// See https://aka.ms/new-console-template for more information
using Mediator.FirstImplementation;

var chatroom = new MainMediator();
// Create participants and register them
AbstractUser a = new Employee("a");
AbstractUser b = new Employee("b");
AbstractUser c = new Employee("c");
AbstractUser d = new Customer("d");
AbstractUser e = new Customer("e");
chatroom.Register(a);
chatroom.Register(b);
chatroom.Register(c);
chatroom.Register(d);
chatroom.Register(e);
// Chatting participants
a.Send("b", "Hi b");
c.Send("d", "Hi d");
e.Send("a", "Hi a");
b.Send("c", "Hi c");
e.Send("e", "Hi e");
// Wait for user
Console.ReadKey();