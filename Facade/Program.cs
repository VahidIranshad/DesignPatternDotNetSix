// See https://aka.ms/new-console-template for more information
var req = new Facade.FirstImplementation.Req { Amount = 100, InstallCount = 10, Type = "Test" };
var reqFacade = new Facade.FirstImplementation.ReqFacade();
reqFacade.Save(req);
Console.ReadKey();
