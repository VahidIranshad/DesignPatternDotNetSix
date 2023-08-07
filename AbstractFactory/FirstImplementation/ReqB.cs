namespace AbstractFactory.FirstImplementation
{
    internal class ReqB : ReqFactory
    {
        public override ISetting CreateSetting()
        {
            return new SettingTypeB();
        }

        public override IValidation CreateValidation()
        {
            return new ValidationTypeB();
        }
    }
}
