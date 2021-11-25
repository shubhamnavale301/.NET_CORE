using System;

namespace CRM
{
    public class Customer
    {
      public int Id{get;set;}
      public string Name{get;set;}
      public double ContactNumber{get;set;}
      public string Email{get;set;}

      public Customer(){
            this.Id=25;
            this.Name="Shubham Navale";
            this.ContactNumber=9552414948;
            this.Email="shubham.navale@hotmail.com";

        }

      public Customer(int id, string name, double phone, string emailid){
            this.Id=id;
            this.Name=name;
            this.ContactNumber=phone;
            this.Email=emailid;

        }
        ~Customer(){         //Deconstructor

        }
    }
}
