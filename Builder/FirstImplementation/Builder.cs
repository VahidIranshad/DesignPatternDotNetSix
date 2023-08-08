namespace Builder.FirstImplementation
{
    internal abstract class Builder
    {
        protected LoanRequest loanRequest;
        public LoanRequest LoanRequest
        {
            get { return loanRequest; }
        }

        // Abstract build methods
        public abstract void AddPrice();
        public abstract void AddIntallcount();
        public abstract void AddRate();
    }
}
