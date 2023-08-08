namespace Builder.FirstImplementation
{
    internal class LoanRequest
    {
        private string _Type;
        public LoanRequest(string type)
        {
            this._Type = type;
        }
        public decimal Price { get; set; }
        public int InstallCount { get; set; }
        public decimal Rate { get; set; }
        public override string ToString()
        {
            return $"Type: {_Type},Price: {Price}, InstallCount: {InstallCount}, Rate: {Rate}";
        }
    }
}
