// See https://aka.ms/new-console-template for more information
using AbstractFactory.FirstImplementation;

Console.WriteLine("What do you need? (A) or (B)?");
char input = Console.ReadKey().KeyChar;
ReqFactory factory;
switch (input)
{
    case 'A':
        factory = new ReqA();
        break;

    case 'B':
        factory = new ReqB();
        break;

    default:
        throw new NotImplementedException();

}
var setting = factory.CreateSetting();
var validation = factory.CreateValidation();

Console.WriteLine("\nSetting: " + setting.GetType().Name);
Console.WriteLine("Validation: " + validation.GetType().Name);

Console.ReadKey();