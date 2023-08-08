namespace Builder.FirstImplementation
{
    internal class HouseLoanRequest : Builder
    {
        public HouseLoanRequest()
        {
            this.loanRequest = new LoanRequest("House");
        }
        public override void AddIntallcount()
        {
            this.loanRequest.InstallCount = 300;
        }

        public override void AddPrice()
        {
            this.loanRequest.Price = 100000;
        }

        public override void AddRate()
        {
            this.loanRequest.Rate = 4;
        }
    }
}
