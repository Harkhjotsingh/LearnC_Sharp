// This is an example to demonstrate Inheritance and how the child Classe(s) can control what constructor of the parent class will/should
// be executed when an object of the child class is executed. (((Because as part of child class execution parent class has to executed 
// to inherit its states and behaviours)))


// Here in child1 we are choosing ""ParentClass(string message)"" constructor to be called by using 
// syntax: <accessModifier><childClassName>() = base(<parametersOfDesiredConstructor>)
// ex:  internal Child1() : base("Wassup!")
//      internal Child2() : base(5)

using System;
namespace ParentAndMainClasses
{
    class ParentClass
    {
        string msg;
        internal ParentClass()
        {
            Console.WriteLine("This is parameter-less Constructor");
        }
        internal ParentClass(string message)
        {
            this.msg = message;
            Console.WriteLine(msg + " This is parameterized Constructor");
        }
        internal ParentClass(int number)
        {
            for(int i = 0; i< number; i++)
            Console.WriteLine("This is another constructor with integer parameters");
        }
    }


    class MainControl
    {
        static void Main(string[] args)
        {
            ChildClasses.Child1 c1 = new ChildClasses.Child1();
            ChildClasses.Child2 c2 = new ChildClasses.Child2();
            Console.ReadLine();
        }
    }
}
 
namespace ChildClasses
{
    class Child1 : ParentAndMainClasses.ParentClass
    {
        internal Child1() : base("Wassup!")
        {
            Console.WriteLine("This is Child1 Constructor");
        }
    }
    class Child2 : ParentAndMainClasses.ParentClass
    {
        internal Child2() : base(5)
        {
            Console.WriteLine("This is Child2 Constructor");
        }
    }
}