// See https://aka.ms/new-console-template for more information

var req = new Bridge.FirstImplementation.Req { Amount = 100, InstallCount = 10 };
var payByBank = new Bridge.FirstImplementation.PayByBank(req);
payByBank.Pay(new Bridge.FirstImplementation.CarReqValidation());
payByBank.Pay(new Bridge.FirstImplementation.HouseReqValidation());

var payByComp = new Bridge.FirstImplementation.PayByCompany(req);
payByComp.Pay(new Bridge.FirstImplementation.CarReqValidation());
payByComp.Pay(new Bridge.FirstImplementation.HouseReqValidation());




Console.ReadKey();