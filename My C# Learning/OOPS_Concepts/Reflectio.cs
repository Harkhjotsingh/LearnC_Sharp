using System;
using System.Reflection;

namespace ReflectionExample
{
    class MainClass
    {
        static void Main()
        {
            Student stu = new Student();
            stu.Print();
            stu.ID = 25;
            stu.Name = "Harkhjot Singh";
            stu.PrintStuInfo();

            Type type = Type.GetType("ReflectionExample.Student");
            Console.WriteLine("Namespcae name is: " + type.Namespace);
            Console.WriteLine("Full name of class is: " + type.FullName);
            Console.WriteLine("Name of the class is: " + type.Name);

            Console.WriteLine();

            #region GetMethods
            Console.WriteLine("Methods in Student Class are listed Below:");
            MethodInfo[] method = type.GetMethods();
            foreach (MethodInfo mthd in method)
            {
                Console.WriteLine(mthd.Name);
            }
            #endregion

            Console.WriteLine();

            #region GetProperties
            Console.WriteLine("Properties in Student Class are listed Below:");
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo property in props)
            {
                Console.WriteLine(property.Name);
            }
            #endregion

            Console.WriteLine();

            #region GetConstructors
            Console.WriteLine("Constructors in Student Class are listed Below:");
            ConstructorInfo[] con = type.GetConstructors();
            foreach (ConstructorInfo constructor in con)
            {
                Console.WriteLine(constructor.ToString());
            }
            #endregion
            Console.Read();
        }
    }
    class Student
    {
        public uint ID { get; set; }
        public string Name { get; set; }

        public Student(uint id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public Student()
        {
            this.ID = 101;
            this.Name = "Harry Minhas";
        }
        public void PrintStuInfo()
        {
            Console.WriteLine("Student ID is: " + this.ID + " Student Name is: " + this.Name);
        }
        public void Print()
        {
            Console.WriteLine("This method is result of lack of Creativity.");
        }
    }
}