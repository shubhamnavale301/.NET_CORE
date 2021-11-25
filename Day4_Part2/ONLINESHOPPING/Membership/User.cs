using System;

namespace Membership
{
    public class User
    {
      public int Id {get;set;}
      public string LoginName{get;set;}
      public string Password{get;set;}

      public static User Register(){
            User newUser=new User();
            newUser.LoginName="Shubhamnavale5";
            newUser.Password="123456";

            return newUser;
        }

      public string SendEmail(){

          return "Email is sent to user id...Thank You";
        }



    }
}
