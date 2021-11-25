
/*
    Use them whenever you feel you can reduce your lines of code. 
    Keep in mind the maintainability while reducing the number of lines of code.
    People think that Lambda Expressions are awkward looking code, 
    but I'm telling you its worth it to use them in code wisely.
*/


using System;

namespace LambdaTest
{
    delegate void doSomething(); 
    delegate int anonymousOperation1(int i); 
    delegate int anonymousOperation2(int a, int b);  // act like a function pointer
    // Object Oriented typesafe managed function Pointer


      
    class Program
    {
        static void Main(string[] args)
        {
            doSomething IamVoid = () => { Console.WriteLine("Hello there! I take nothing and return nothing"); };  
            //call the Anonymous function  
            IamVoid();  

            anonymousOperation1 proxy = new anonymousOperation1(  
                                                        delegate(int x){  
                                                            return x * 2;
                                                        }
                                    );  

            Console.WriteLine("{0}", proxy(5));  

            anonymousOperation1 proxy2 = x => x * 2;  //x => x * 2 is the expression that is the known as Lambda Expression

            //(input parameters) => Expression; 
            anonymousOperation2 proxyBigInteger = (x, y) => { if (x > y) return x; else return y; };  // Logic
            int result=proxyBigInteger(10,15);  // invoking agent
                                      // reference pointing to instance of delegate
                                      // delegate is registered with  logic
                                      // dynamic invoking logic


            // Proxy:
            // proxy war : Pakistan will going with India proxy war from more than 25 years


            Console.WriteLine(result);  
            Console.WriteLine("{0}", proxy2(25));  
            Console.WriteLine("Hello World!");
        }
    }
}
