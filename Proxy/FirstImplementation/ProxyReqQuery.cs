namespace Proxy.FirstImplementation
{
    public class ProxyReqQuery : IQuery
    {
        ReqQuery _reqQuery;
        public ProxyReqQuery()
        {
            _reqQuery = new ReqQuery();
        }
        public void GetData()
        {
            if (CheckAccess())
            {
                _reqQuery.GetData();
                Log();
            }
        }
        private bool CheckAccess()
        {
            Console.WriteLine("Check Access");
            return true;
        }
        private void Log()
        {
            Console.WriteLine("Log");
        }
    }
}
