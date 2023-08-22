namespace TemplateMethod.FirstImplementation
{
    internal abstract class Req
    {
        Model Request;
        public Req(Model request)
        {
            Request = request;
        }
        public void Save()
        {
            Check();
            Insert();
            Pay();
        }
        protected abstract void Check();
        protected abstract void Insert();
        protected abstract void Pay();
    }
}
