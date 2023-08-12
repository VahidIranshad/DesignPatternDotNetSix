// See https://aka.ms/new-console-template for more information

using Composit.FirstImplementation;

var report = new Menu("Report");
var req = new Menu("Request");


var menu = new Menu("Main");

report.Add(new MenuItem("Analyze", "..."));

req.Add(new MenuItem("LoanCarReqest", "..."));
req.Add(new MenuItem("LoanHouseRequest", "..."));

menu.Add(report);
menu.Add(req);

menu.Print();
Console.ReadKey();