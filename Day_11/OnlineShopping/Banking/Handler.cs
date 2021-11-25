using System;
// Listener
// Hook
// Handler
// Each class should be independently Tested:
// Unit Testing:
// Dynamic Invocation
// .NET Types: Delegate ,Event
//

namespace Banking {


    //Callback function
    //Impose Policy
    //Impose Rule
    //
    public class Handler {

        //Each method of Handler will match
        // Signature of Delegate
        public  void BlockAccount(){          
            Console.WriteLine( " The Account has been blocked....");
        }

        public  void SendEmailNotification(){
             Console.WriteLine( "Email notification has been sent to registered email address");    
        }
        public void PayIncomeTax(){
             Console.WriteLine( " Income tax has been deducted from your Account by Order...");
        }

        public void PayServiceTax(){
             Console.WriteLine( " Service tax has been deducted from your Account by Order...");
        }

        public void PayProfessionalTax(){
             Console.WriteLine( " Professional tax has been deducted from your Account by Order...");
    
        }

    }
}