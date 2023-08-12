namespace Adapter.FirstImplementation
{
    /* assume this class is from another library*/
    internal class CarLoanCheck
    {
        private readonly CarLoanRequest _carLoanRequest;
        public CarLoanCheck(CarLoanRequest carLoanRequest)
        {
            _carLoanRequest = carLoanRequest;
        }
        public void CehckPrice()
        {
            Console.WriteLine("Check Price from CarLoanCheck");
        }
        public void CehckCountOfInstall()
        {
            Console.WriteLine("Check CountOfInstall from CarLoanCheck");
        }
    }
}
