namespace Memento.FirstImplementation
{
    internal class Model
    {
        public string Property { get; set; }
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(Property);
        }
        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Property = memento.Property;
        }
        public void Display()
        {
            Console.WriteLine($"Property : {Property}");
        }
    }
}
