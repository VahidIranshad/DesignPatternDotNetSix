namespace Observer.FirstImplementation
{
    internal interface ISubject
    {
        void Attach(Form observer);

        void Detach(Form observer);
        void Notify();
    }
}
