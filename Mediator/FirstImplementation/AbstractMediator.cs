namespace Mediator.FirstImplementation
{
    public abstract class AbstractMediator
    {
        public abstract void Register(AbstractUser participant);
        public abstract void Send(
            string from, string to, string message);
    }
}
