using System;

class MainClass //: MulticastDeligatesExample
{
    static void Main()
    {
        MulticastDeligatesExample obj = new MulticastDeligatesExample();
        
        
 //FIRST WAY       
        //instance of delegate MultiDeligate
        MultiDelegate delegate1, delegate2, delegate3, delegate4, delegate5;
        delegate1 = new MultiDelegate(obj.Method1);
        delegate2 = new MultiDelegate(obj.Method2);
        delegate3 = new MultiDelegate(obj.Method3);
        delegate4 = new MultiDelegate(obj.Method4);
        delegate5 = delegate1 + delegate2 + delegate3 + delegate4 - delegate2;
        delegate5();                                                                         // Invoking multi-cast Delegate.

//SECOND WAY 
        Console.WriteLine("---------------------------------");
        MultiDelegate commonDelegate = new MultiDelegate(obj.Method1);
        commonDelegate += obj.Method2;
        commonDelegate += obj.Method3;
        commonDelegate += obj.Method4;
        commonDelegate -= obj.Method3;
        commonDelegate();                                                                               // Invoking multi-cast Delegate.

        Console.ReadLine();
    }
}

public delegate void MultiDelegate();

class MulticastDeligatesExample
{
    //Methods
    public void Method1()
    {
        Console.WriteLine("This is method 1");
    }

    public void Method2()
    {
        Console.WriteLine("This is method 2");
    }

    public void Method3()
    {
        Console.WriteLine("This is method 3");
    }
    public void Method4()
    {
        Console.WriteLine("This is method 4");
    }
}


/* :::::::::::::::::::::    MULTICAST DELEGATES   :::::::::::::::::::::::::
    
    A multi-cast delegate is a delegate that points to more than one functions.
    Whenever this delegate is invoked it invkoes all the methods that it is pointitng to. This list of functions/methods is called Invocation List. 

    There are 2 WAYS to achive this.

    FIRST WAY: By creating multiple instances of the a delegate. 
    Steps: 
    1. Declare multiple delegates reference variables.Ex: -->> see line 12. I have created multiple instances of the delegate MultiDelegate.(delegate1 delegate2 delegate3..)
    2. Create objects for each variable created and point to the respective methods for which they are initialized. -->> See line 13,14,15 and 16.
    3. Use another delegate reference variable to add all other using "+" operator.-->> See line 17. Now this delegate(delegate5 in our case) has a list to functions
       to be calles. This list is called INVOCATION LIST. 
    4. Now invoke this delegate. -->> see line 18. 
    5. When this delegate is invoked it will invoke all the functions in the invocation list. 
    
    NOTE:: If we do not want any particular function to be called, just use "-" operator to remove the delegate pointing to it. For example: In line 17 we have removed 
           delegate2 from the invocation list.   
           
    SECOND WAY: By using a single/common reference variable. This method saves us some typing. 
    Steps: 
    1. Delcare a delegate pointing to function like we normally do. -->>See line 22. 
    2. Now using the reference variable from the above delegate add functions that you to want to be in the invocation list using "+=" operator. -->> see lines 23 to 25.
    3. Invoke the delegate and it will invoke all the functions in the invocation list. 
    
    NOTE:: If we do not want any particular function to be called, just use "-=" operator to remove the delegate pointing to it. For example: In line 26 we have removed 
           Method3() from the invocation list. 
           
    ********************************************  NOTE  *****************************************************
    1. If a multicast delegate is called for non void method and it is returning some value to a variable/function then it will return the value from last function in the 
    invocation list. Read it a few times and it will make sence.(It worked for me and I'm an idiot,sure it will work for anyone)
    2. Same is true for methods with out parameters.
*/
