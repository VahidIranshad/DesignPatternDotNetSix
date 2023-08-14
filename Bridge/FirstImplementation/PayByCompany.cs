namespace Bridge.FirstImplementation
{
    internal class PayByCompany : IPay
    {
        private readonly Req _req;
        public PayByCompany(Req req)
        {
            _req = req;
        }
        public void Pay(IValidation validation)
        {
            Console.WriteLine("Start PayByCompany");
            validation.Validate(_req);
            Console.WriteLine("End PayByCompany");
        }
    }
}
