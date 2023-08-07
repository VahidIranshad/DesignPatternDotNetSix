namespace FactoryMehtod.FirstImplementation
{
    internal interface IItem
    {
        void GetInfo();
    }
    internal class Bread : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Bread");
        }
    }
    internal class Tea : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Tea");
        }
    }
    internal class Coffee : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Coffee");
        }
    }
    internal class Bacon : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Bacon");
        }
    }
    internal class Egg : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Egg");
        }
    }
    internal class Sausages : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Sausages");
        }
    }
    internal class Cheese : IItem
    {
        public void GetInfo()
        {
            Console.WriteLine("Cheese");
        }
    }
}
