namespace Flyweight.FirstImplementation
{
    internal class CarValidation : IValidation
    {
        DateTime date;
        public CarValidation()
        {
            date = DateTime.Now;
        }
        public void Check(Req req)
        {
            Console.WriteLine($"CarValidation : {date.ToLongTimeString()}");
        }
    }
}
