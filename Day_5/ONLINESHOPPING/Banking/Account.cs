using System;

namespace Banking
{
    public class Account
    {
       public double Balance{get; set;}

       public Account(double amount){
           this.Balance=amount;
        }

    public void Monitor(){
                if(this.Balance<5000){
                    //Handler.BlockAccount();  //Static linking of behaviour from
                }                             // Handler.cs file
                else if(this.Balance>=250000){
                    //Handler.PayIncomeTax();
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

       public static Account Create(double initialamount){
        Account acct= new Account(initialamount);
        return acct;
        }

      

    }

}
