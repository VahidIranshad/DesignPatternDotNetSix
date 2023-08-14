namespace Bridge.FirstImplementation
{
    internal class PayByBank : IPay
    {
        private readonly Req _req;
        public PayByBank(Req req)
        {
            _req = req;
        }
        public void Pay(IValidation validation)
        {
            Console.WriteLine("Start PayByBank");
            validation.Validate(_req);
            Console.WriteLine("End PayByBank");
        }
    }
}
