using System;
namespace MyName
{
    interface IStudent1
    {
        void PrintStuName1();
    }
    interface IStudent2 : IStudent1
    {
        void PrintStuName2();
    }
    class MyClass : IStudent2 
    {
        string stuName;
        public string Name
        {
            set
            {
                stuName = value;
            }
            get { return stuName; }
        }

        public void PrintStuName1()
        {
            Console.WriteLine("Interface1 --> Student Name is " + stuName);
        }

        public void PrintStuName2()
        {
            Console.WriteLine("Interface2 --> Student Name is " + stuName);
        }
    }
    class MainClass
    {
        static void Main()
        {
            MyClass stu1 = new MyClass();
            stu1.Name = Console.ReadLine();
            stu1.PrintStuName1();
            stu1.PrintStuName2();

            Console.WriteLine();
            
            // Interface reference-variable pointing to derived class Object.  
            IStudent1 stu2 = new MyClass();
            stu2.PrintStuName1();

            Console.Read();
        }
    }

}



/*
    :::INTERFACES::: 
    -> Interfaces are a lot like classes,they can have methods,properties,delegates and events but they can only have behaviour decleration not defination/implimentation.   
       And they cannot have any states/fileds. 
    -> An interface can inherit from another interface. 
    -> Classes and structures can interface from one or more interfaces at the same time. 
    -> Interface members are always public by default, so access modifiers on interface members dosent really make sense.
    -> A class that is inheriting the interface MUST provide implimentations of all its behaviours. That is if a class ClassA is inherting an interface IInterfaceA, then
       it must provide implementation for all its member methods and behaviours.
    -> Interfaces can inherit from other interfaces. When a class inherits an interface that inherits other interfaces, then the class has to provide the implimentations
       for all the interface members in the inheritance chain. 
       Example: If InterfaceA inherits InterfaceB and ClassA inherits InterfaceB, then it automatically have access to InterfaceA members (multi-level Inheritance). So
       in this case ClassA has to provide implimentation to members of InterfaceA and InterfaceB. See the above code example where MyClass provides implementations for
       both IStudent1 and IStudent2(IStudent2 inherits from IStudent1).

    IMPORTANT: We cannot create an instance of an Interface but an Interface referenceVariable can point to a derived/child/sub class Object.(just like a parent/base
    class reference variable can point to a child class object).
    If you think about it, an Interface instance dosent really make sence, because even if we create one what are we goona do with it? there is no method definations in
    an interface.  SEE line 45.

    :::::::::::::::::NOTE:::::::::::::::::

    Its a commmon nameing convention to Start the interface name with a upper case "I". It helps differentiating them from classes just by looking at them. 

*/