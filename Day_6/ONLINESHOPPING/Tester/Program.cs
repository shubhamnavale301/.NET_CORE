using System;
using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using Banking;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
           Product p1=new Product();
           p1.Id=23;
           p1.Title="TATA SAFARI";
           p1.Description="Automatic Car";
           p1.UnitPrice=5000;
           p1.Quantity=100;

           Console.WriteLine(p1.Id);
           Console.WriteLine( "Name:"+ p1.Title);
           Console.WriteLine(p1.Description);
           Console.WriteLine(p1.UnitPrice);
           Console.WriteLine(p1.Quantity);

/////////////////////////////////////////////////////////////////////////////

          Customer thecustomer=new Customer(30,"Rakesh Kothare",9819675240,"rakesh.kothare@gmail.com");
          Console.WriteLine(thecustomer);
/////////////////////////////////////////////////////////////////////////////

          User newUser=User.Register();
          Console.WriteLine("New user is created successfully");
          Console.WriteLine("Username:"+newUser.LoginName);
          Console.WriteLine("Userpassword:"+newUser.Password);

          newUser.SendEmail();
///////////////////////////////////////////////////////////////////////////////
          Order theorder=new Order();
              theorder.Id=500501;
              theorder.OrderDate=DateTime.Now;
              theorder.Status="Order is Processed";
              theorder.TotalAmmount=100;

          Console.WriteLine("Order Status:"+theorder.Status);
////////////////////////////////////////////////////////////////////////////////

          Account acct1=Account.Create(5000);
          Account acct2=Account.Create(6000);

          double acct1Balance=acct1.Balance;
          Console.WriteLine("Balance1="+ acct1Balance);

          double acct2Balance=acct2.Balance;
          Console.WriteLine("Balance2="+ acct2Balance);
////////////////////////////////////////////////////////////////////////////////

          AccountDetails Details=new SavingAccount();
          Account acct3=Details.CreateAccount();
          double acct3Balance=acct3.Balance;
          Details.ShowAccountDetails();
          Console.WriteLine("Balance3="+ acct3Balance);



          
            Console.WriteLine("Hello World!");
        }
    }
}
