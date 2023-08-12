namespace Composit.FirstImplementation
{
    internal class Menu : Component
    {
        List<Component> _components = new List<Component>();

        public Menu(string name)
        {
            this.Name = name;

        }
        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Menu : {Name}");
            Console.WriteLine("___________");
            foreach (var menuComponent in _components)
            {
                menuComponent.Print();
            }
            Console.WriteLine();
        }
    }
}
