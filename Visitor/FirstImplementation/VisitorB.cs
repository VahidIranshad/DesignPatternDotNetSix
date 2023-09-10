namespace Visitor.FirstImplementation
{
    internal class VisitorB : IVistor
    {
        public void VisitModelA(IModel model)
        {
            Console.WriteLine("VisitorB ModelA");
        }

        public void VisitModelB(IModel model)
        {
            Console.WriteLine("VisitorB ModelB");
        }
    }
}
