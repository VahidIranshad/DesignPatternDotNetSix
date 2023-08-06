namespace Prototype.SecondImplementation
{
    [Serializable]
    internal class Car : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }


        public override void GetInfo()
        {
            Console.WriteLine($"Brand : {this.Brand} - Model : {this.Model}");
        }
    }
}
