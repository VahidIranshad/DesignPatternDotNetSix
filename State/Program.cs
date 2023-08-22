// See https://aka.ms/new-console-template for more information
using State.FirstImplementation;

Account account = new Account("Vahid Iranshad");
account.Deposit(500.0);
account.Deposit(300.0);
account.Deposit(550.0);
account.PayInterest();
account.Withdraw(2000.00);
account.Withdraw(1100.00);

Console.ReadKey();
