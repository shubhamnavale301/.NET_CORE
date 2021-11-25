using System;

namespace Catalog
{
    public class Product
    {
      public int Id{get;set;}
      public string Title{get;set;}
      public string Description{get;set;}   //Data Members (State)
      public string ImageUrl{get;set;}
      public double UnitPrice{get;set;}
      public int Quantity{get;set;}

      public Product(){
          this.Id=1;
          this.Title="TATA NANO";
          this.Description="Automatic Car";
          this.UnitPrice=1000;
          this.Quantity=500;
      }

      public Product(int id, string title, string description, double unitprice, int quantity ){
          this.Id=id;
          this.Title=title;
          this.Description=description;
          this.UnitPrice=unitprice;
          this.Quantity=quantity;
          
    }
    }
}


