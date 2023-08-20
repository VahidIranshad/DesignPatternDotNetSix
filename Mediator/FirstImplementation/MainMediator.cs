namespace Mediator.FirstImplementation
{
    public class MainMediator : AbstractMediator
    {
        private Dictionary<string, AbstractUser> users = new Dictionary<string, AbstractUser>();
        public override void Register(AbstractUser participant)
        {
            if (!users.ContainsValue(participant))
            {
                users[participant.Name] = participant;
            }
            participant.Mediator = this;
        }
        public override void Send(string from, string to, string message)
        {
            var participant = users[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}

