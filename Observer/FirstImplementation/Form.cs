namespace Observer.FirstImplementation
{
    internal abstract class Form
    {
        public readonly DateTime dateCreated ;
        public Form()
        {
            dateCreated = DateTime.Now;
            Thread.Sleep(1000);
        }
        public string Color { get; set; } = "Default Color";
        //public abstract void Update(string color); 
        public virtual void Update(string color)
        {
            this.Color = color;
            Console.WriteLine($"{this.GetType().Name} : {this.Color} dateCreated: {this.dateCreated.ToLongTimeString()}");
        }
    }
}
