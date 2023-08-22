namespace TemplateMethod.FirstImplementation
{
    internal class LoanHouseReq : Req
    {
        public LoanHouseReq(Model request) : base(request)
        {

        }
        protected override void Check()
        {
            Console.WriteLine("LoanHouseReq Check");
        }

        protected override void Insert()
        {
            Console.WriteLine("LoanHouseReq Insert");
        }

        protected override void Pay()
        {
            Console.WriteLine("LoanHouseReq Pay");
        }
    }
}
