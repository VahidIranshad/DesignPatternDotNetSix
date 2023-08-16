namespace Flyweight.FirstImplementation
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, IValidation> _vadations;

        public FlyweightFactory()
        {
            _vadations = new Dictionary<string, IValidation>();
        }

        public IValidation GetValidation(Req req)
        {
            Thread.Sleep(1000);
            if (req == null)
            {
                throw new ArgumentNullException();
            }
            _vadations.TryGetValue(req.GetType().Name, out var iValidation);
            if (iValidation == null)
            {
                switch (req.GetType().Name)
                {
                    case "HouseReq":
                        iValidation = new HouseValidation();
                        _vadations.Add("HouseReq", iValidation);
                        break;
                    case "CarReq":
                        iValidation = new CarValidation();
                        _vadations.Add("CarReq", iValidation);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return iValidation;
        }
    }
}
