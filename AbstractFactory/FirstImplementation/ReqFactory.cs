namespace AbstractFactory.FirstImplementation
{
    internal abstract class ReqFactory
    {

        public abstract ISetting CreateSetting();
        public abstract IValidation CreateValidation();
    }
}
