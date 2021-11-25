using System;
namespace Banking
{
    // used as blueprint for creating number of instances 
    // C Sharp provides kewords
    // const, types
    // Value Types
    //      int, float, char, boolean
    // Reference Types
    //       class, delegate, event

    public delegate void Operation();
    public class Account
    {
        //Auto Property
        public double Balance{get;set;}
        public Account(double amount){
            this.Balance=amount;
        }

        // User defined Events

        // if you want to defined event, first you need to define delegate
        // Account class is Publisher
        // it publish events
        public event Operation underBalance;
        public event Operation overBalance;


        // Don't repeat your self:
        public  void Monitor(){
            if( this.Balance < 5000){
                // static linking of behaviour
                // applying Dynamic linking
               // handler.BlockAccount();
               //raise an Event
               //
               underBalance();
            }
            else if(this.Balance>=250000){
                // static linking of behaviour
                // appylying Dynamic Linking
                //handler.PayIncomeTax();
                // raise an Event;
                overBalance();
            }
        }
        public void Deposit(double amount){
            this.Balance+=amount;
            Monitor();
        }

        public void Withdraw(double amount){
            this.Balance-=amount;
            Monitor();
        }


        //helper function which will create object and
        // give you reference of the object      
        public static Account Create(double initialAmount){
            Account account=new Account(initialAmount);
            return account;
        }   
    }
}
