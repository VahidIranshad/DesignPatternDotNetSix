namespace Composit.FirstImplementation
{
    internal abstract class Component
    {
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public abstract void Print();

        public virtual string Name { get; set; }
    }
}
