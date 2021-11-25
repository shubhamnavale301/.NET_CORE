using System;

namespace Banking
{
    public class Account
    {
       public double Balance{get; set;}

       public Account(double amount){
           this.Balance=amount;
        }
       public void Deposit(double amount){
           this.Balance+=amount;
        }
       public void Withdraw(double amount){
           this.Balance-=amount;
        }

    public static Account Create(double initialamount){
        Account acct= new Account(initialamount);
        return acct;
    }



       



    }
}
