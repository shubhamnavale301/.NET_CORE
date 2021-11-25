using System;

namespace Banking{

    public class SavingAccount:AccountDetails{

         void AccountDetails.ShowAccountDetails(){
            Console.WriteLine("Show Account Details:--");

        } 

         Account AccountDetails.CreateAccount(){
            return Account.Create(15000);


        }

    }

}