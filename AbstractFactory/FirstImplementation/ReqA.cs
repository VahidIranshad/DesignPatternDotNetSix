namespace AbstractFactory.FirstImplementation
{
    internal class ReqA : ReqFactory
    {
        public override ISetting CreateSetting()
        {
            return new SettingTypeA();
        }

        public override IValidation CreateValidation()
        {
            return new ValidationTypeA();
        }
    }
}
