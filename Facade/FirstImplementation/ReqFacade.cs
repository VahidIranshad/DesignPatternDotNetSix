namespace Facade.FirstImplementation
{
    internal class ReqFacade
    {
        private readonly Validation _validation;
        private readonly DataAccess _dataAccess;
        /// <summary>
        /// you can get different classes in ctor in different ways dpi or etc
        /// </summary>
        public ReqFacade()
        {
            _validation = new Validation();
            _dataAccess = new DataAccess();
        }
        public void Save(Req req)
        {
            Console.WriteLine("satrt facade");
            _validation.CheckValidation(req);
            _dataAccess.Insert(req);
            Console.WriteLine("end facade");
        }
    }
}
