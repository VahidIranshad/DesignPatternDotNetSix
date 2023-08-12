namespace Adapter.FirstImplementation
{
    internal class HouseReqValidation : IReqValidation
    {
        private readonly HouseReq _houseReq;
        public HouseReqValidation(HouseReq houseReq)
        {
            _houseReq = houseReq;
        }

        public void CehckAmount()
        {
            Console.WriteLine("Check Price from HouseReqValidation");
        }

        public void CehckInstallCount()
        {
            Console.WriteLine("Check CountOfInstall from HouseReqValidation");
        }
    }
}
