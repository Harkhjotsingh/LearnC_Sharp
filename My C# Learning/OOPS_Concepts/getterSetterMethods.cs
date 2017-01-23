using System;
namespace MyName
{
    class Student
    {
        private uint stuId;
        private string stuName = "";
        private uint passingMarks = 33;

        public void SetStuId(uint id)
        {
            if (id <= 0)
            {
                throw new Exception("Student Id should be non-zero and positive");
            }
            else
            { stuId = id; } 
        }
        public uint GetStuId()
        {
            return stuId;
        }
        public void SetStuName(string name)
        {
            if(name==null || name == "")
            {
                throw new Exception("Student name cannot be null");
            }
            else { stuName = name; }
        }
        public string GetStuName()
        {
            if(stuName == "") { stuName = "No Name"; return stuName; }
            else { return stuName; }
        }
        public uint GetPassMarks()
        {
            return passingMarks;
        }
    }
class MainClass
    {
        static void Main()
        {
            Student stu1 = new Student();
            stu1.SetStuId(10);
            stu1.SetStuName("ChickoSulvakia");
            Console.WriteLine("Student id is: "+stu1.GetStuId());
            Console.WriteLine("Student name is: " + stu1.GetStuName());
            Console.WriteLine("Student id is: " + stu1.GetPassMarks());
            Console.ReadLine();
        }
    }
}
