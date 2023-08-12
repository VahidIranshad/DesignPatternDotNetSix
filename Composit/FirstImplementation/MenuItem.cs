namespace Composit.FirstImplementation
{
    internal class MenuItem : Component
    {
        public MenuItem(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Description { get; set; }
        public override void Print()
        {
            Console.WriteLine($"MenuItem : {Name}");
        }
    }
}
