using System;

namespace Constructor
{
    class EmpInfo
    {
        string empName;
        string empId;

        public EmpInfo() : this("No Name provided", "No ID provided")
        {

        }

        public EmpInfo(string employeeName, string empployeeId)
        {
            this.empName = employeeName;
            this.empId = empployeeId;
        }

        public void printEmpInfo()
        {
            Console.WriteLine("Name: " + this.empName + " ID: " + this.empId);
        }
    }
}

namespace ClassExample
{
    public class ClassExp
    {
        static void Main(string[] args)
        {
            Constructor.EmpInfo emp1 = new Constructor.EmpInfo("Harry Minhas", "10B91A0436");
            emp1.printEmpInfo();

            Constructor.EmpInfo emp2 = new Constructor.EmpInfo();
            emp2.printEmpInfo();
            Console.ReadLine();
        }
    }
}

