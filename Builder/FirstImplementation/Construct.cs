namespace Builder.FirstImplementation
{
    internal class Construct
    {
        public void Assemble(Builder builder)
        {
            builder.AddPrice();
            builder.AddRate();
            builder.AddIntallcount();
        }
    }
}
