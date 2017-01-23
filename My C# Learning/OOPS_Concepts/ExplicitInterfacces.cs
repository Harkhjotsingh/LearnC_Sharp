using System;
namespace MyName
{
    interface IStudent1
    {
        void PrintStuName();
    }
    interface IStudent2 
    {
        void PrintStuName();
    }
    class MyClass : IStudent1,IStudent2 
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

        // interface method implimentations
        public void PrintStuName()                                                // Default (declared normally)
        {
            Console.WriteLine("Interface1 --> Student Name is " + stuName);
        }

        void IStudent2.PrintStuName()                                             // Explicit implimentation. <returnType> <interfaceName>.<Method/BehaviourName>
        {
            Console.WriteLine("Interface2 --> Student Name is " + stuName);
        }
    }
    class MainClass
    {
        static void Main()
        {

            MyClass stu1 = new MyClass();
            Console.Write("Enter the name: ");
            stu1.Name = Console.ReadLine();
            stu1.PrintStuName();
            ((IStudent2)stu1).PrintStuName();                                                // Typecasting stu1 to be IStudent2 reference variable.

            Console.WriteLine();
            
            // Interface reference-variable pointing to derived class Object.  
            IStudent1 stu2 = new MyClass();
            stu2.PrintStuName();
            ((IStudent2)stu2).PrintStuName();                                               // Typecasting stu2 to be IStudent2 reference variable.

            Console.Read();
        }
    }

}





/*
    :::EXPLICIT INTERFACES:::
    Suppose a Class inherits from more than 1 interface(s) or from a chain of interface-inheritance. Now if these interfaces has a method with same signature
    (name and parameters) then when the class implements these methods there is an ambiguity problem i.e. it cannot be known which method is
    implimented(although doing so dosent results into any error). Even if we impliment both the methods we cannot say which method is for which interface.
    
    To solve this problem we need Explicit Interface Implimentation.  
    Syntax : 
                <returnType> <interfaceName>.<Method/BehaviourName> 
                {
                    // Statements/behaviour/functionality
                }
                
                ex:  void IStudent2.PrintStuName()  // line 30
                {
                    Console.WriteLine("Interface2 --> Student Name is " + stuName);
                }

 NOTE :: 1. ACCESS MODIFIERS are NOT ALLOWED in Explicit Interface Implimetation.

         2. Explicitly implimented interfaces can only be accessed by concerned Interface's reference Variabble.
            Syntax:: ((<InterfaceName>)<referenceVariableName>).<Explicitly_Implimented_Method_Name> 
            example:   See line 44 and 51.
            ((IStudent2)stu1).PrintStuName();
            ((IStudent2)stu2).PrintStuName(); 

         3. If we want to make,the same signature method default for any of the interface, just declare it normally(but the rest has to be calles Explicitly.
            No more than one method(of same signature of course) can be called normally.). This way if any instance calls same signature
            method, it will be called for an Interface which is not implimented Explicitly. I know this is confusing. Lets see an example from the above program. 
            
            Example:
            In line 30, I have implimented the PrintStuName() method using Explicit implimentation for interface IStudent2, that means whenever I want to call this 
            method I have to use Interface reference variable(from point 2) but if I dont do that, the default implementation is called, implented normally on line 25.
            Its called on line 43 and 50. It DOES NOT need Interface reference variable.  
     
     */
