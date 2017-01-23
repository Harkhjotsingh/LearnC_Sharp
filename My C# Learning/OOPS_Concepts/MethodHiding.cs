/*################################################ METHOD HIDING ############################     PreRequeist -- Inheritance Concept
 Method hiding is concept in which a prevoius method of Parent Class can be overridden by a Child Class method of same name. 
 -> For example:
 if both parent and Child class have method called MyMethod(), the defination of Child method will be called when an instance of child 
 class is created. 
 
 -> Ex from this Program:
 see first FullTimeStudent class instance, the defination of PrintStuInfo() is called for that object(i.e from FullTimeStudent Class,
 hence PrintStuInfo() method from Student is Overridden).  

 In the above secnario the compiler throws an error that "FullTimeStudent.PrintStuInfo() hides inherited member Student.PrintStuInfo().
 Use the new keyword if the hiding was intended." , this is nothing but a warning to notify the developer that method hiding took plcae. As
 suggested by warning using "new" after access modifer of the method get rids of the warning, ensuring that method hiding is intentional 
 and the developer has not used the same method name by mistake.
 -> Example from this Program:
    See for FullTimeStudent Class there is a green line under PrintStuInfo() method indicating warning.     BUT
    for PrintStuInfo() method in PartTimeStudent Class there is no such warning as "new" keyword is used to declare the method.

 --------------WHAT IF WE HAVE 2 OBJECTS AND IN ONE CASE WE WANT TO HIDE INHERITED METHOD BUT NOT IN THE SECOND ONE????????-------------
 Ans:: No panic! There are ways.
 1. TypeCasting the reference variable pointing to Child class,with Parent Class at the time of calling the method. READ IT THREE TIMES
 -> Example Syntax : (<parentclassName>(<referencevariablename>)).<callingmethod()>;
 -> Example from this Program : Second Object = ((Student)parttimestu1).PrintStuInfo(); 

 2. IMPORTANT CONCEPT:::: By creating a reference Variable of Parent Class Pointing to Child Class Object.   READ IT THREE TIMES
 -> Example Syntax : <parentclassName><referenceVariabeName> = new <ChildClassConstructor()>;
 -> Example from this Program : Third object =  Student fulltimestu2 = new FullTimeStudent();

 NOTE:::: Its only valid for a Parent Class reference variable to point to Child Object, as Child Class has all the abilities of its Parent.
          i.e Student fulltimestu2 = new FullTimeStudent();   -->> //VALID

          However its not possible for a child class reference variable to point to Parent Class object as child class may have additional 
          features that may not be present in Parent Class. 
          i.e FullTimeStudent fulltimestu2 = new Student();  -->> //INVALID

          !!!!!!!!!!!!!!!!!!!!!!_______THIS IS IMPORTANT CONCEPT FOR POLYMORPHISM________!!!!!!!!!!!!!!!!!!!!!!!!!!!!
*/


using System;

namespace MethodHiding
{
    class Student
    {
        public string studentName;
        public byte studentAge;

        internal void PrintStuInfo()
        {
            Console.WriteLine("Student Name is: " + studentName);
            Console.WriteLine("Student Age is: " + studentAge);
        }
    }

    class FullTimeStudent : Student
    {

        internal void PrintStuInfo()
        {
            Console.WriteLine("Student Name is: " + studentName + "-Fulltime");
            Console.WriteLine("Student Age is: " + studentAge);
        }
    }

    class PartTimeStudent : Student
    {
        internal new void PrintStuInfo()
        {
            Console.WriteLine("Student Name is: " + studentName + "-Parttime");
            Console.WriteLine("Student Age is: " + studentAge);
        }
    }

    class MainClass
    {
        static void Main()
        {
            // First Object showing method hiding
            FullTimeStudent fulltimestu = new FullTimeStudent();
            fulltimestu.studentName = "Harry";
            fulltimestu.studentAge = 23;
            fulltimestu.PrintStuInfo();

            // Avoiding Method hiding using TypeCasting
            PartTimeStudent parttimestu1 = new PartTimeStudent();
            parttimestu1.studentName = "Rantu";
            parttimestu1.studentAge = 24;
            ((Student)parttimestu1).PrintStuInfo();                   // Typecasting

            // Avoiding Method Hiding by using base "class reference variable to point to derived class object"
            Student fulltimestu2 = new FullTimeStudent();
            fulltimestu2.studentName = "Rahul";
            fulltimestu2.studentAge = 25;
            fulltimestu2.PrintStuInfo();

            Console.ReadLine();
        }
    }
}
