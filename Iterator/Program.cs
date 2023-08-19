// See https://aka.ms/new-console-template for more information
using Iterator.FirstImplementation;

var collection = new Collection();
collection[0] = new Model("Model 1");
collection[1] = new Model("Model 2");
collection[2] = new Model("Model 3");
collection[3] = new Model("Model 4");
collection[4] = new Model("Model 5");
collection[5] = new Model("Model 6");
collection[6] = new Model("Model 7");
collection[7] = new Model("Model 8");
collection[8] = new Model("Model 9");

// Create iterator
var iterator = collection.CreateCollectionIterator();


for (Model item = iterator.First();
    !iterator.IsDone; item = iterator.Next())
{
    Console.WriteLine(item.MyProperty);
}

Console.ReadKey();
