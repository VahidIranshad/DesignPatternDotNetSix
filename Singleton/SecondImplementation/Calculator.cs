namespace Singleton.SecondImplementation
{
    internal class Calculator
    {
        private static object syncRoot = new object();

        private bool IsCalculating;
        private static readonly Lazy<Calculator> _singleton = new Lazy<Calculator>(() => new Calculator());

        public static Calculator Instance() => _singleton.Value;

        private Calculator()
        {
            Console.WriteLine("Starting");
        }


        public void Calc()
        {
            if (IsCalculating)
            {
                Console.WriteLine("is calculating...");
                return;
            }
            Console.WriteLine("start calculating...");
            IsCalculating = true;
            IsCalculating = false;
            Console.WriteLine("end calculating...");
        }

    }
}
