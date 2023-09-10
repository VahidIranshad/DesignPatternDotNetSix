namespace Visitor.FirstImplementation
{
    internal class ModelA : IModel
    {
        public void Accept(IVistor vistor)
        {
            Console.WriteLine("Model A");
            vistor.VisitModelA(this);
        }
    }
}
