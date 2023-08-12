namespace Adapter.FirstImplementation
{
    internal class CarLoanValidationAdapter : IReqValidation
    {
        private readonly CarLoanCheck carLoanCheck;
        public CarLoanValidationAdapter(CarLoanRequest carLoanRequest)
        {
            carLoanCheck = new CarLoanCheck(carLoanRequest);
        }
        public void CehckAmount()
        {
            carLoanCheck.CehckPrice();
        }
        public void CehckInstallCount()
        {
            carLoanCheck.CehckCountOfInstall();
        }
    }
}
