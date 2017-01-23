/* #################################----THIS IS POLYMORPHISM EXAMPLE----#############################################
 *
 * Polymorphism General Defination:: the condition of occurring in several different forms.
 * 
 * OOPS DEFINATION: Polymorphism allows the programmer to use the overriding method of derived/child/sub class in a derived class object pointed 
 * by base class reference variable. ------------Confusing right???
 * What we need to understand here is WHAT IS METHOD OVERRIDING?  
   
 Method Overriding is overriding the base class method by a derived class method i.e the method called by the object will be the one defined/declared
 in the derived/child class.
 -> Wait! Isn't that METHOD HIDING???
  No it's not, its slightly different. Try to recall the point that "a base class reference variable can point to derived class object". So
  when we declare an object something like this <baseClassName> <referenceVariableName> = new <derivedClassConstructor()> 
  even though method hiding is done it still calls the base class methods. So to solve this problem METHOD OVERIDING is done, i.e even  if
  we declare the object in the above fashion, we can call the derived class methods. Got it?? If not may Horus(https://en.wikipedia.org/wiki/Horus) helps you. 
  Or you can always read it again.
  
  *****************************HOW TO OVERRIDING METHOD????*************************
    To overide a method we will use to keywords "virtual" (in the base class method defination) and "overide" (in the derived class method 
    defination).
    So, if we want to overide a method we have to define it as virtual in the base class and as override in derived class. These keywords are used between the
    access modifier and return type of the method declaration. 
    In below example we are doing this to printName() method. 

    $$$$---THIS OVERRIDING OF METHOD AND CALLING THE DERIVED CLASS METHOD FOR BASE CLASS REFERENCE VARIABLE IS CALLED POLYMORPHISM---$$$$
    
    Try figuring out the Output.
               
    Lets see the example  
 
 */

using System;
namespace Polymorphism
{
    class baseClass
    {
        public String firstName = "Harry";
        public String lastName = "Minhas";

        public virtual void printName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    class derivedClass1_FTS : baseClass
    {
        //Method OverRiding
        public override void printName()
        {
            Console.WriteLine(firstName + " " + lastName +" - fullTime");
        }

    }
    class derivedClass2_PTS : baseClass
    {
        //Method OverRiding
        public override void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " - partTime");
        }
    }
    class derivedClass3_TEMP_S : baseClass
    {
        //Method Hiding
        public new void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temprary");
        }
    }
    class MainClass
    {
        static void Main()
        { 
        baseClass[] students = new baseClass[4];           // array of baseClass objets.
            students[0] = new baseClass();                 // 1st baseClass reference variable(students[0]) pointing to basClass itself.
            students[1] = new derivedClass1_FTS();         // 2nd baseClass reference variable(students[1]) pointing to derivedClass1_FTS
            students[2] = new derivedClass2_PTS();         // 3rd baseclass reference variable(students[2]) pointing to derivedClass2_PTS
            students[3] = new derivedClass3_TEMP_S();      // 4th baseclass reference variable(students[3]) pointing to derivedClass3_TEMP_S

            foreach (baseClass stu in students)            // Calling printName() method on each Object.
            {
                stu.printName();
            }

        Console.ReadLine();
        }
    }
}