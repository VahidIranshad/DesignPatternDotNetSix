// See https://aka.ms/new-console-template for more information

using Builder.FirstImplementation;

Builder.FirstImplementation.Builder builder;

var construct = new Builder.FirstImplementation.Construct();

builder = new HouseLoanRequest();
construct.Assemble(builder);
Console.WriteLine(builder.LoanRequest.ToString());

builder = new CarLoanRequest();
construct.Assemble(builder);
Console.WriteLine(builder.LoanRequest.ToString());

Console.ReadKey();