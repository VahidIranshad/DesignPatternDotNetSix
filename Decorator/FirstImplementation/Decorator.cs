namespace Decorator.FirstImplementation
{
    internal abstract class Decorator : Req
    {
        protected readonly Req _req;
        public Decorator(Req req)
        {
            _req = req;
        }
        public abstract override void Display();
    }
}
