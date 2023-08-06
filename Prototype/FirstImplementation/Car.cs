namespace Prototype.FirstImplementation
{
    internal class Car : IShowInfo
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public object Clone()
        {
            return new Car() { Brand = this.Brand, Model = this.Model };    
        }

        public void GetInfo()
        {
            Console.WriteLine($"Brand : {this.Brand} - Model : {this.Model}");
        }
    }
}
