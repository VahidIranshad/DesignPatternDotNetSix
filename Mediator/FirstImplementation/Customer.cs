namespace Mediator.FirstImplementation
{
    internal class Customer : AbstractUser
    {
        public Customer(string name)
            : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Customer: ");
            base.Receive(from, message);
        }
    }
}
