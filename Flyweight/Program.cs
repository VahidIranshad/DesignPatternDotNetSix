// See https://aka.ms/new-console-template for more information
var fleyweight = new Flyweight.FirstImplementation.FlyweightFactory();
var carReq = new Flyweight.FirstImplementation.CarReq();
var houseReq = new Flyweight.FirstImplementation.HouseReq();
var validation1 = fleyweight.GetValidation(new Flyweight.FirstImplementation.CarReq());
var validation2 = fleyweight.GetValidation(new Flyweight.FirstImplementation.HouseReq());
var validation3 = fleyweight.GetValidation(new Flyweight.FirstImplementation.CarReq());
var validation4 = fleyweight.GetValidation(new Flyweight.FirstImplementation.HouseReq());
var validation5 = fleyweight.GetValidation(new Flyweight.FirstImplementation.CarReq());
var validation6 = fleyweight.GetValidation(new Flyweight.FirstImplementation.HouseReq());

validation1.Check(carReq);
validation2.Check(houseReq);
validation3.Check(carReq);
validation4.Check(houseReq);
validation5.Check(carReq);
validation6.Check(houseReq);

Console.ReadKey();