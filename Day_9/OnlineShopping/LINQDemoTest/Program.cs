using System;
using System.Reflection;


namespace LINQDemoTest
{

    // Every class is bydefault inherited from Object class
    // goes in java , CSharp, Javascript, Typescript

    class Program
    {
        static void Main(string[] args)
        {
            // How do you check type of variable at runtime ?
            // C ++  ------> RTTI
            // Java  -------> Reflection
            // C#    -------> Reflection
            Program theProgram=new Program();
            Console.WriteLine( "Demo for Reflection");
            Type theType1=theProgram.GetType();
            Console.WriteLine("Type of theProgram variable: "+ theType1.Name);


            var instance= new { Id=34, FirstName="Ravi", LastName="Tambade",
                                EmailAddress="ravi.tambade@transflower.in",
                                ContactNumber="9881735801",
                                Location=new {
                                                LandMark="Walvekar Garden",
                                                City="Pune",
                                                State="Maharashtra",
                                                Country="India"
                                }
            };
            Type theType2=instance.GetType();
            Console.WriteLine("Type of theType2" +theType2.Name);
            
            Console.WriteLine( "Demo for Annonumous Data Type....");
            Console.WriteLine(instance.FirstName + " " + instance.LastName);
            Console.WriteLine(instance.Location.Country);
            Console.WriteLine(instance.Location.State);
            Console.WriteLine(instance.Location.City);
            Console.WriteLine(instance.Location.LandMark);
            Console.WriteLine("Hello World!");
        }
    }
}
