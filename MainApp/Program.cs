using Domain.Models;
using Infrastructure.Services;

// var customer1 = new Customers();
// customer1.Name = "Mustafo";
// customer1.Balance = 1000;

// var customer2 = new Customers();
// customer2.Name = "Barotov";
// customer2.Balance = 100;

// var customer3 = new Customers();
// customer3.Name = "Salom";
// customer3.Balance = 500;

// var customerSer = new CustomerService();
// customerSer.AddCustomers(customer1);
// customerSer.AddCustomers(customer2);
// customerSer.AddCustomers(customer3);

// var tra1 = new Transactions();
// tra1.Data = new DateTime(2024,03,05);
// tra1.Summa = 100;
// tra1.SenderId = 1;
// tra1.TakerId = 2;

// var tra2 = new Transactions();
// tra2.Data = new DateTime(2024,02,14);
// tra2.Summa = 250;
// tra2.SenderId = 2;
// tra2.TakerId = 3;

// var tra3 = new Transactions();
// tra3.Data = new DateTime(2024,01,25);
// tra3.Summa = 400;
// tra3.SenderId = 3;
// tra3.TakerId = 1;

var traService = new TransactionService();
// traService.AddTransactions(tra1);
// traService.AddTransactions(tra2);
// traService.AddTransactions(tra3);

// foreach (var item in traService.JournalFinance())
// {
//     System.Console.WriteLine("Id : " + item.Id);
//     System.Console.WriteLine("Data : " + item.Data);
//     System.Console.WriteLine("Summa : " + item.Summa);
//     System.Console.WriteLine("SenderId : " + item.SenderId);
//     System.Console.WriteLine("TakerId : " + item.TakerId);
//     System.Console.WriteLine("------------------------------");
// }

// System.Console.WriteLine("*******************************************************");

// foreach (var item in traService.TransactionsHistory(3))
// {
//      System.Console.WriteLine("Id : " + item.Id);
//     System.Console.WriteLine("Data : " + item.Data);
//     System.Console.WriteLine("Summa : " + item.Summa);
//     System.Console.WriteLine("SenderId : " + item.SenderId);
//     System.Console.WriteLine("TakerId : " + item.TakerId);
//     System.Console.WriteLine("------------------------------");
// }










