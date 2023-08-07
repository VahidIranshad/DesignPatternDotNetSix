namespace FactoryMehtod.FirstImplementation
{
    internal class SimpleBreakfast : Breakfast
    {
        public override void CreateItems()
        {
            Items.Add(new Bread());
            Items.Add(new Cheese());
            Items.Add(new Tea());
        }
    }
}
