namespace FactoryMehtod.FirstImplementation
{
    internal class AdvancedBreakfast : Breakfast
    {
        public override void CreateItems()
        {
            Items.Add(new Bread());
            Items.Add(new Egg());
            Items.Add(new Sausages());
            Items.Add(new Bacon());
            Items.Add(new Coffee());
        }
    }
}
