namespace Builder.FirstImplementation
{
    internal class CarLoanRequest : Builder
    {
        public CarLoanRequest()
        {
            this.loanRequest = new LoanRequest("Car");
        }
        public override void AddIntallcount()
        {
            this.loanRequest.InstallCount = 12;
        }

        public override void AddPrice()
        {
            this.loanRequest.Price = 200000;
        }

        public override void AddRate()
        {
            this.loanRequest.Rate = 2;
        }
    }
}
