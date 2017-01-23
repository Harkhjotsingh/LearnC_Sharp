using System;

interface IA
{
    void AMethod();
}
interface IB
{
    void BMethod();
}

class ClassA :IA
{
    public void AMethod()
    {
        Console.WriteLine("This method of Iinterface IA is implemented by ClassA");
    }
}

class ClassB : IB
{
    public void BMethod()
    {
        Console.WriteLine("This method of interface IB is implemented by ClassB");
    }
}

class ClassC : IA, IB
{
    ClassA a = new ClassA();
    ClassB b = new ClassB();

    public void AMethod()
    {    
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
    static void Main()
    {
        ClassC obj = new ClassC();
        obj.AMethod();
        obj.BMethod();

        Console.Read();
    }
}


/*
    As we know C# does not support multiple class inheritance. 
    If we really need to have functionalities of two classes in a third class i.e.  if we need to inherit from more than one class, how do we do it? 

    Well if there is a will, there is a way. We have a work around. So the trick is
    suppose we have a class C which wants to inherit from class A and B.
    
    ::STEPS::
    
    1. Declare interfaces for both A and B.-->> line 3 and 7.
    2. Inherit from respective interfaces and declare memeber definations. .-->> line 12 and 20.   
    3. Declare class C and inherit from Interface-A and Interface-B. -->> line 28.   Remember now we have to provide method definations for both Interface-A And Interface-B members.
    4. Create objects of A and B class. -->> line 30 and 31.
    5. Now while providing definations for interface members in class C use above "a" and "b" objects to call member definations from A and B Classes. -->>line 35 and 39. This way we
       get the exact member definations from Class A and B in Class C.
    6. Now to use all features/members of ClassA and ClassB, create an object of ClassC. -->> line 43.
    7. Call all the member you want. -->> line 44 and 45


    NOTE:: I have only used one member from each base Class (AMethod() and BMethod()). We can use as many members we want.

 */
