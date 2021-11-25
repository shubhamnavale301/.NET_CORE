using System;
using Banking;

namespace Handlertest
{   public delegate void AccountOperation();




    class Program
    {
        static void Main(string[] args)
        {
            Handler theHandler= new Handler();
            //Static Linking
           // theHandler.BlockAccount();
            theHandler.PayIncomeTax();
            
            //Dynamic linking
            AccountOperation operation1=new AccountOperation(theHandler.BlockAccount);
            AccountOperation operation2=new AccountOperation(theHandler.SendEmail);
            
            //Multicasting or broadcasting 
            AccountOperation operation=operation1;
            operation+=operation2;


            operation();   
            Console.WriteLine("Hello World!");
        }
    }
}
