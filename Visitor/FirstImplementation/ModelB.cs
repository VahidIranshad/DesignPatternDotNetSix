namespace Visitor.FirstImplementation
{
    internal class ModelB : IModel
    {
        public void Accept(IVistor vistor)
        {

            Console.WriteLine("Model B");
            vistor.VisitModelB(this);
        }
    }
}
