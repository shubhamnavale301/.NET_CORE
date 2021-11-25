using System;

namespace Test
{   


  class person
  {  //member variables
    public string firstname;
    public string lastname;
    public int age;

    //constructor

    public person(){
          firstname="Tejas";
          lastname="navale";
          age=20;
    }
  
    public person(string fname,string lname,int ag){
         this.firstname=fname;
         this.lastname=lname;
         this.age=ag;
    }
         


  }
   





   class Handler    //Crud operations
   { 
     public static void processGetRequest(){
          Console.WriteLine("Processing Get logic");

      }

     public static void processPostRequest(){
          Console.WriteLine("Processing Post logic");

      }

      public static void processUpdateRequest(){
          Console.WriteLine("Processing Update logic");

      }

      public static void processDeleteRequest(){
          Console.WriteLine("Processing Delete logic");

      }

}








    class Program
    {   
    //Reusable function    
        static void Display(){
            Console.WriteLine("Processing Display logic");
        }

        static void Show(){
            Console.WriteLine("Processing Show Logic");
        }

    //Entry Point Function....Always invoke external function to main function
        static void Main(string[] args)
        {   
           int count=23;
           count=count+1;
           bool status=true;
           string name="Shubham Navale";

           Console.WriteLine("Name=" +name);
           Console.WriteLine(count);
           Console.WriteLine(status);
           Console.WriteLine("Hello World!");

           Show();
           Display();

           Handler.processGetRequest();
           Handler.processPostRequest();
           Handler.processUpdateRequest();  //CRUD Operations Invoking under main function
           Handler.processDeleteRequest();

           person person1=new person("virat","kohli",30);
           /*person.firstname="Kalpesh";
           person.lastname="sharma";
           person.age=25;*/

           person person2=new person("rohit","sharma",31);
           /*person.firstname="Lokesh";
           person.lastname="verma";
           person.age=24;*/

           Console.WriteLine(person1.firstname + " " + person1.lastname +" " +person1.age);
           Console.WriteLine(person2.firstname + " " + person2.lastname +" " +person2.age);
           Console.ReadLine();
        }
    }
}
