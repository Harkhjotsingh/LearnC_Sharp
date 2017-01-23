using System;

namespace MyName
{
    public delegate void DelegatePrint(string msg);

    class MainClass
    {
        static void Main()
        {
            MainClass refobj = new MainClass();

            DelegatePrint obj = new DelegatePrint(refobj.PrintMethod);
            obj("This is a delegate accessing a Method");

            DelegatePrint obj1 = new DelegatePrint(refobj.AddNumbers);
            obj1("10");

            Console.Read();
        }
        public void PrintMethod(string Message)
        {
            Console.WriteLine("You Wrote: " + Message);
        }

        public void AddNumbers(string num)
        {
            int res = 4 + Convert.ToInt32(num);
            Console.WriteLine("The result is: " + res);
        }
    }
}

/* 
    ::::::DELEGATES::::::
 Defination: A Delegate is "type safe" pointer to a function.

    A Delegate's syntax is very similar to that of a method and it really matters :-  A delegate can point to any method similar to its own signature defination.

    To provoke a method via delegates we have to create an instance of the delegate(jsut like a class). Also we have to pass the method name as a parameter to the
    delegate's Constructor . see line -->> 13 and 14.

    for example: if a delegate is declared something like <accessModifier> delegate <returnType> <delegateName>(<datatype> <parameter(s)Name>)
                                                          public delegate void MyDelegate(int a)
                                                          
    Now this delegate can point to any method with same return type and parameters. see line -->> 14 and 17. delegate DelegatePrint points to method PrintMethod() as they have
    same return type and parameters(type and number).
                    
    NOTE:: This example is just to get an idea of a delegate. This does not tells us why we need Delegates, just what it is.
    
    So WHY DELEGATES?? Another day buddy,another day.  
  
*/
