namespace FactoryMehtod.FirstImplementation
{
    abstract class Breakfast
    {
        private List<IItem> _items = new ();

        public Breakfast()
        {
            CreateItems();
        }
        public void GetInfo()
        {
            foreach (var item in Items)
            {
                item.GetInfo();
            }
        }
        //Factory method
        public abstract void CreateItems();

        public List<IItem> Items
        {
            get { return _items; }
        }
    }
}
