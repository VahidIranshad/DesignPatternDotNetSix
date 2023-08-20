namespace Mediator.FirstImplementation
{
    internal class Employee : AbstractUser
    {
        public Employee(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Employee: ");
            base.Receive(from, message);
        }
    }
}
