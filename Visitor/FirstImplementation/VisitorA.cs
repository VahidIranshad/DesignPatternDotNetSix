namespace Visitor.FirstImplementation
{
    internal class VisitorA : IVistor
    {
        public void VisitModelA(IModel model)
        {
            Console.WriteLine("VisitorA ModelA");
        }

        public void VisitModelB(IModel model)
        {
            Console.WriteLine("VisitorA ModelB");
        }
    }
}
