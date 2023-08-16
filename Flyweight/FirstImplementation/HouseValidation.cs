namespace Flyweight.FirstImplementation
{
    internal class HouseValidation : IValidation
    {
        DateTime date;
        public HouseValidation()
        {
            date = DateTime.Now;
        }
        public void Check(Req req)
        {
            Console.WriteLine($"HouseValidation : {date.ToLongTimeString()}");
        }
    }
}
