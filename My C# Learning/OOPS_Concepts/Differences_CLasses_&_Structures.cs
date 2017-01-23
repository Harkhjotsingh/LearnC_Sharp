using System;
namespace EmptyNameSpace
{
    public /*sealed*/ class EmptyClass
    {
        internal void EmptyMethod()
        {
            Console.WriteLine("This is just a empty method in empty class in empty Namespace. Well not technically but we will take it.");
        }
    }
}

namespace StructAndClassDifferences
{
    public class MyClass
    {
        public string stuName { get; set; }
        public int stuId { get; set; }
        internal void PrintStuInfo()
        {
            Console.WriteLine("Student id is " + this.stuId);
            Console.WriteLine("Student name is " + this.stuName);
        }
        ~MyClass()
        {

        }
    }
    public struct MyStruct
    {
        public string stuName { get; set; }
        public int stuId { get; set; }
        internal void PrintStuInfo()
        {
            Console.WriteLine("Student id is " + this.stuId);
            Console.WriteLine("Student name is " + this.stuName);
        }

       /* ~MyStruct()
        {

        }*/

     /* public MyStruct()
        {

        }*/
    }
    public class MainClass : EmptyNameSpace.EmptyClass
    {
        static void Main()
        {
            // Class objects. 
            MyClass stu1 = new MyClass();
            stu1.stuId = 101;
            stu1.stuName = "Harry";
            //stu1.PrintStuInfo();

            // copying class(reference type) to another class object. 
            MyClass stu2 = stu1;
            stu2.stuId = 102;
            stu2.stuName = "Happy";
            stu1.PrintStuInfo();
            stu2.PrintStuInfo();

            Console.WriteLine();
           
            // Structure 
            MyStruct s1 = new MyStruct();
            s1.stuId = 201;
            s1.stuName = "Minhas";
            // copying struct(value type) to another struct. 
            MyStruct s2 = s1;
            s2.stuId = 202;
            s2.stuName = "Pabla";
            s1.PrintStuInfo();
            s2.PrintStuInfo();

            Console.ReadLine();
        }
    }
}


/* 
    DIFFERENCES BETWEEN STRUCTURES AND CLASSES
 
    There are quite a few differences between structures and classes but the most important one is STRUCTURES ARE VALUE TYPES AND CLASSES ARE REFERENCE
    TYPE.
    What is value type and referene type? 
                                        VALUE TYPE                |                       REFERENCE TYPE
    1. In Value type the variable contains the actual value.      |      1. It contains the address location of the actual value. Its a pointer to the value.
    2. It is stored in the stack Memory.                          |      2. The reference variable is store in stack but the actual value is stored in the Heap. 
    3. Variable is destroyed(deleted from memory) immediately     |      3. Only the reference variable is deleted from the memory immediately, actual values/data
       after its scope.                                           |         is cleared by garbage collector when it sees no variable is pointing to the data. 
    4. Examples of value types are premitive datatypes(except     |      4. Examples of reference types are general datatypes(string and objects),interfaces,delegates and
       general datatype),enums and of course STRUCTURES.          |         of course CLASSES.
    5. When a value type is copied to another value type, changes |       5. When a reference type is copied to another value type, changes on one of the values effects
       on one of the values dosent effect the other value.        |          the other value as both are poinnting to the same memory location.     
                                                                  |
  From the above differences we can say that the whatever is applicable to the value and reference type is applicable to structures and classes respectively. i.e 
  1. Structures hold their values in the memory where they are declared(stored on stack), whereas classes holds a reference to an object in the memory(stored in heap). 
  2. Structures are destroyed immediately after their scope is lost whereas objects of the classes are collected by garbage collector. 
  3. When a strucuture is copied to another structure,a new copy is created and changes on either of the copies does not effects the other copy. SEE Structures under Main() method.
     On the other hand when a class object is copied to another class object, another reference variable is created that points to the same memory location of the class object. 
     Therefore changes to the objects reflects on both reference variable. SEE Class objects under Main() method.

    OTHER DIFFERENCES: 
    1. Structures cannot have destructors where as classes can. UnComment line 39 to 42 to see this. 
    2. Structures cannot have explicit parameter-less constuctors whereas classes can. UnComment line 44 to 47 to see this.
    3. A struct cannot inherit from a struct, but a class can inherit from another class. Although both can inherit from an interface. 
       Structures are selaed type i.e nobody can inherit from them.  

    NOTE::::: BY USING SEALED KEYWORD WE CAN MAKE THE CLASS INHERITABLE(that class cannot be inherited). UnComment sealed keyword in line 4 to see this.
     
*/

