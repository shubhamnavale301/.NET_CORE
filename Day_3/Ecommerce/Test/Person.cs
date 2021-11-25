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
}  