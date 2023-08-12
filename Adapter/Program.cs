// See https://aka.ms/new-console-template for more information
var car = new Adapter.FirstImplementation.CarLoanRequest { CountOfInstall = 1, Price = 20 };
var carReqValidation = new Adapter.FirstImplementation.CarLoanValidationAdapter(car);

Check(carReqValidation);

var house = new Adapter.FirstImplementation.HouseReq { InstallCount = 2, Amount = 30 };
var houseReqValidation = new Adapter.FirstImplementation.HouseReqValidation(house);

Check(houseReqValidation);


static void Check(Adapter.FirstImplementation.IReqValidation reqValidation)
{
    reqValidation.CehckAmount();
    reqValidation.CehckInstallCount();
}

Console.ReadKey();