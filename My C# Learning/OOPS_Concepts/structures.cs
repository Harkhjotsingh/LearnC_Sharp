// Structure Example

using System;
namespace MyName
{
    struct Student
    {
        private string stuName;
        private uint stuId;

        public uint Id
        {
            set { stuId = value; }
            get { return stuId; }
        }

        public string Name
        {
            get{ return stuName; }

            set {stuName = value;}
        }

        public Student(uint sId, string sName)
        {
            this.stuId = sId;
            this.stuName = sName;
        }

        public void PrintStuInfo()
        {
            Console.WriteLine("Student id is: "+ this.stuId );
            Console.WriteLine("Student name is: " + this.stuName);
            Console.WriteLine();  // just for a line space
        }
    }
    class MainClass
    {
        static void Main()
        {
            /* Here I will assign value to fiellds in ways.*/
            
            //1. Using the constructor.
            Student stu1 = new Student(08, "Harry");
            stu1.PrintStuInfo();

            //2. Using the properties.
            Student stu2 = new Student();
            stu2.Name = "Rahul";
            stu2.Id = 23;
            stu2.PrintStuInfo();

            /*3. Using Object-Initializer Syntax. which can be used to initialize both class and structure objects. It looks like this: 
                 <structName> <referenceVariableName> = new <structName>
                 {
                   <filed1> = <Corrospondingvalue>,
                   <field2> = <Corrospondingvalue>,
                   .
                   .
                   .
                   <fieldn> = <Corrospondingvalue>
                 };
            */
            Student stu3 = new Student
            {
                Id = 15,
                Name= "Ranti"
             };
            stu3.PrintStuInfo();

            Console.ReadLine();         
       }
    }
}

/*
    What are structures?? why we need them??
    --> I don't really know,maybe thats a topic for another day. Lets just learn about their properties and behaviours (in general term not
    in programming termnologies)

    --> They posses all the properties (again in general term not in programming termnologies) of a class. That means a structure can have 
    states and behaviours(this time in programming terminologies) like private fields, methods, a constructor and properties.
 
    We can assign the values to the states and behaviours in the same way as we assign the values in the class. see line 43 and 47. 
    In .NET 3.0 another synatax was introduced to allow assigning values to the states of the structure. This syntax is called
    OBJECT-INTITIALIZER syntax. see line 53.  


*/
