// See https://aka.ms/new-console-template for more information

using Memento.FirstImplementation;

var s = new Model();
s.Property = "First Change";
s.Display();
// Store
ProspectMemory m = new ProspectMemory();
m.Memento = s.SaveMemento();
// Continue changing originator
s.Property = "Second Change";
s.Display();
// Restore
s.RestoreMemento(m.Memento);
s.Display();


Console.ReadKey();