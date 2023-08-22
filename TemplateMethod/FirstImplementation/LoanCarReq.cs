namespace TemplateMethod.FirstImplementation
{
    internal class LoanCarReq : Req
    {
        public LoanCarReq(Model request):base(request)
        {

        }
        protected override void Check()
        {
            Console.WriteLine("LoanCarReq Check");
        }

        protected override void Insert()
        {
            Console.WriteLine("LoanCarReq Insert");
        }

        protected override void Pay()
        {
            Console.WriteLine("LoanCarReq Pay");
        }
    }
}
