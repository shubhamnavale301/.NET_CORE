﻿using System;
using Banking;
using CentralGovtAdministration;

namespace EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Handler handler=new Handler();
            //NDAGovtHandler handler=new NDAGovtHandler();
            
            UPAGovtHandler handler=new UPAGovtHandler();
            Account account1=Account.Create(10000);


            //at runtime register event handlers with events associated with Account
            //attach event handlers with events associated with Account object

            //associate at runtime with event receiver--------handler
            //associate at runtime with event handler---------handler
            //associate at runtim with  Contorller------------handler

            //Event Mapping
            //Event Registration
            //Add Hooks to Events
            //subscribe callback function to event of account

            account1.overBalance+=new Operation(handler.PayIncomeTax);
            account1.overBalance+=new Operation(handler.PayServiceTax);
         
            // Banking transaction
            account1.Balance=56000;

            //Highly Cohesive exeuction happening
            Console.WriteLine("Before first deposit");
            account1.Deposit(200000);
            Console.WriteLine("After first deposit");
            account1.overBalance+=new Operation(handler.PayServiceTax);
            account1.Deposit(12000);

            Console.WriteLine(" For another account instance...");
            Console.WriteLine(" NDA");

            NDAGovtHandler handler2=new NDAGovtHandler();
            Account account2=Account.Create(37000);
            account2.overBalance+=new Operation(handler2.PayServiceTax);
            account2.Deposit(230000);
            Console.WriteLine("Hello World!");
        }
    }
}
