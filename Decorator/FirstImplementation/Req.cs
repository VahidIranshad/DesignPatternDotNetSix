namespace Decorator.FirstImplementation
{
    internal abstract class Req
    {
        public int Amount { get; set; }
        public decimal InstallCount { get; set; }

        public virtual void Display()
        {
            Console.WriteLine(this.GetType().Name);
        }

    }
}
