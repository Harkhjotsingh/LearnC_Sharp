// Static and Instance variables and methods Example

using System;

namespace StaticAndInstance
{
    class Employee
    {
        ulong eid;
        string ename;
        double esal;
        static string compNane;
        static ulong compPhno;

        internal Employee(ulong empid,string empname,double empsal)
        {
            this.eid = empid;
            this.ename = empname;
            this.esal = empsal;
        }
        static Employee()
        {
            Employee.compNane = "Palette";
            Employee.compPhno = 0402440436; 
        }
        internal double GrossSalary()
        {
            double hra = esal * 0.4;
            double ta = esal * 0.3;
            double da = esal * 0.2;
            double tax = esal * 0.13;
            double grossSalary = esal + hra + ta + da -tax;
            return grossSalary;
        }
        internal void EmpInfo()
        {
            Console.WriteLine("Employee id is: {0}", eid );
            Console.WriteLine("Employee name is: {0}", ename);
            Console.WriteLine("Employee salary is: "+ GrossSalary());
            Console.WriteLine("Company nae is: {0}", compNane);
            Console.WriteLine("Company contact is: {0}", compPhno);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(12458454,"Harry",1890);
            emp1.EmpInfo();

            Employee emp2 = new Employee(121421465, "Happy", 2000);
            emp2.EmpInfo();

            Console.ReadLine();
        }
    }
}
