namespace Decorator.FirstImplementation
{
    internal class HouseRequestDecorator : Decorator
    {
        public HouseRequestDecorator(Req req) : base(req)
        {

        }
        public override void Display()
        {
            Console.WriteLine($"Amount : {this._req.Amount} , InstallCount : {_req.InstallCount}");
        }
    }
}
