using System;
using System.Linq;
using System.Collections.Generic;
namespace AnalyticsTest
{
    class Person  
    {  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public int Age { get; set; }   
    }   
    class Program
    {
        static void Main(string[] args)
        {
            FindAllNumbersMultipleOf2();
            ShowAllNames();
            GetReport();
        }

    //The preceding example loops through the entire collection of numbers and 
    //each element (named x) is checked to determine 
    //if the number is a multiple of 2 (using the Boolean expression (x % 2) == 0).
    static void FindAllNumbersMultipleOf2(){
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  

        foreach (var num in evenNumbers)  
        {  
            Console.Write("{0} ", num);  
        }  
        Console.WriteLine();  
    }


    //List that contains all the Participnats Name. 
    static void ShowAllNames(){

        List<Person> participants = new List<Person>() {   
            new Person { FirstName = "Ajinkya",LastName = "Tambbade" ,Age = 19 },  
            new Person { FirstName = "Neha",LastName = "Bhor", Age = 21 },  
            new Person { FirstName = "Mayuresh",LastName = "Wanjare", Age = 3 } ,
            new Person { FirstName = "Umesh",LastName = "Kimar", Age = 30},  
            new Person { FirstName = "Swarali",LastName = "Lakade", Age =23 },  
            new Person { FirstName = "Ankur",LastName = "Prasad", Age = 28 }  
        }; 

        var peopleResult = participants.Select(x => new {
                                                            Age = x.Age, 
                                                            FirstLetter = x.FirstName,
                                                            LastNameLetter = x.FirstName[0] 
                                                         }
                                        );  

        foreach (var person in peopleResult)  
        {   
            Console.WriteLine(person);  
        }   
    }

    // Get reports of all studetns names in UpperCase 
    // Where name consist of i, 
    // Order by length of characters
    static void GetReport()
    {
        string[] students = new string[] { "Neha", "Akanksha", "Mayuresh", "Shubham","Bill" ,
                                            "Rohit", "Siddhachakra" ,"Ajinkya","Sumeet","Hemant","Mohit",
                                            "Amol","Rajiv","Kimaya","Santosh","Nilesh","Umesh","Manishankar",
                                            "Amitabh","Swarali","Kamal","Steve","Priyadarshani","Jaiprakash",
                                            "Rutuja"
                                        };

        var filterNamebyChar = students.Where(n => n.Contains('i'));
        var NamesOrderedBy = filterNamebyChar.OrderBy(n => n.Length);
        var InUpperCase = NamesOrderedBy.Select(n => n.ToUpper());

        //  In short this can be written  as shown below:
        //  var InUpperCase = students.Where(n => n.Contains('i')).OrderBy(n => n.Length).Select(n => n.ToUpper());

        Console.WriteLine("\nStudents names containing i in Inreasing Order in Upper Case ");
        
        //Imperative Query Expressions result
        foreach (var item in InUpperCase)
        {
            Console.WriteLine(item);
        }
    }
}
}


