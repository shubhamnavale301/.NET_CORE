using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace SerializationTest
{
    [Serializable]
    public class Product
    {
      public int Id{get;set;}
      public int Likes{get;set;}
      public string Title{get;set;}
      public string Description{get;set;}   //Data Members (State)
      public string ImageUrl{get;set;}
      public double UnitPrice{get;set;}
      public int Quantity{get;set;}

     
    }

      
    class Program{
      static void Main(string[] args)
        {   

        Product newproduct=new Product();  //Creating Object of the Product
        
        










            Console.WriteLine("Hello World!");
        }
    }
}
