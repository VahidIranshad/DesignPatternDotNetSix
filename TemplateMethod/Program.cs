// See https://aka.ms/new-console-template for more information
using TemplateMethod.FirstImplementation;
Model model = new() { InstallCount = 10, Price = 100 };
Req houseReq = new LoanHouseReq(model);
Req carReq = new LoanCarReq(model);
houseReq.Save();
carReq.Save();
Console.ReadKey();