using System;
using MyName;
namespace MyName
{
    abstract class AbsClass
    {
        public int Method1_Add(int i,int j)
        {
            int res = i + j;
            return res;
        }

        public abstract void Method2_Print();
    }

    class MainClass : AbsClass
    {
        public override void Method2_Print()                       // implementation of abstract method(Method2_Print) from abstract class(AbsClass)
        {
            Console.WriteLine("This is a print method");
        }

        static void Main(string[] args)
        {
            int result=0;                                           // Main method Local variable 

            MainClass obj = new MainClass();
            obj.Method2_Print();
            result = obj.Method1_Add(3,4);
            Console.WriteLine("The Sum is:" +result);
            Console.WriteLine();
            //AbsClass obj1 = new AbsClass();                         // INVALID. Cannot make an instance of abstract class.

            AbsClass obj1 = new MainClass();                          // VALID. Remember Base-Class reference-variable can point ot Derived-Class object. Holds true for abstract classes too.  
            obj1.Method2_Print();
            Console.Read();

        }
    }
}

namespace Abs
{
  abstract class AbsClass2 : AbsClass
    {
        // This class inherits another abstract class. 
    }
}

/*
    :::::::::ABSTRACT CLASSES:::::::::

    As the name suggets abstract-class is an abstract of the class. These classes are not complete or they can be. 
    To intitialize these classes "abstract" keyword is used. 
    Syntax:: <accessmodifier> <abstract> <class> <className>
    {
        // States and Behaviours.
    }

    Some Important Features of Abstract Classes are:-
    
    0. As the rule of Inheritance states, A Base-Class reference-variable can point ot Derived-Class object. An abstract class reference variable can point to a Child/derived class 
       object who is inheriting it. Example: See line 34.-->> AbsClass obj1 = new MainClass();

    1. Abstract classes can have behaviours with or without defintaion. Methods/behaviours with no defination must use abstract keyword. for ex: in AbsClass Method2_Print() is an 
       abstract method with no method defination, whereas  Method1_Add(int i,int j) has method defination.
       Therefore An abstract class may contain abstract members(methods,properties,indexers and events) but its not a must.
        
    2. Abstract classes cannot be instantiated as some of the members might be abstract(with no defination).

    3. Any class that is inheriting the abstract class has to provide defination for its abstract members. Example: line 17. MainClass provides defination for abstract method
       Method2_Print() of Abstract Class AbsClass.

    4. An Abstract class cannot be sealed, as this will stop it from being Inherited, which is the only thing we can do with it.(since it cannot be instantiated)

    5. If a class is inherting an abstract class either it has to provide defintaion for its abstract members(as in MainClass)  
                                                            OR
    it itself has to be an abstract Class (as in AbsClass2).  


DOES IT SOUNDS SIMILAR TO INTERFACES????  It is similar. But they have their differences, we'll see that later. 
     
*/
