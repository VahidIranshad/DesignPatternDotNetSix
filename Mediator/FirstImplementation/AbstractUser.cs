namespace Mediator.FirstImplementation
{

    public abstract class AbstractUser
    {
        MainMediator mediator;
        string name;
        // Constructor
        public AbstractUser(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public MainMediator Mediator
        {
            set { mediator = value; }
            get { return mediator; }
        }
        public void Send(string to, string message)
        {
            mediator.Send(name, to, message);
        }
        public virtual void Receive(
            string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
    }

}
