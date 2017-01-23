using System;
namespace Emp
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string empId;

        public void EmpInfo()
        {
            Console.WriteLine("Employee name is: " + firstName +" "+ lastName);
            Console.WriteLine("Employee Id is: " + empId);
            
        }

    }
    class FullTime : Employee
    {
        public float anualSalary;

        public void EmpInfo()
        {
            Console.WriteLine("Employee name is: " + firstName + " " + lastName + " - FullTime");
            Console.WriteLine("Employee Id is: " + empId);

        }

        public void EmpSalary()
        {
            Console.WriteLine("Employee salary is: " + anualSalary );
            Console.ReadLine();
        }
    }

    class PartTime : Employee
    {
        public float hourlySalary;
        public void EmpInfo()
        {
            Console.WriteLine("Employee name is: " + firstName + " " + lastName + " - PartTime");
            Console.WriteLine("Employee Id is: " + empId);

        }

        public void EmpSalary()
        {
            Console.WriteLine("Employee salary is: " + hourlySalary);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTime emp1 = new FullTime();
            emp1.firstName = "Mahesh";
            emp1.lastName = "Babu";
            emp1.empId = "537NR66A";
            emp1.anualSalary = 3200000;
            emp1.EmpInfo();

            PartTime emp2 = new PartTime();
            emp2.firstName = "Ranti";
            emp2.lastName = "Dev";
            emp2.empId = "537NR66B";
            emp2.hourlySalary = 400;
            emp2.EmpInfo();
            Console.ReadLine();
        }
    }
}


//NOTES:::
/*                                                   #### INHERITANCE ####
 * Inheritance is a concept in which one class(child class) can inhert the states and behaviours of the other
 * class(called parent/base class) i.e the child class object/instance will have access to all behavoiurs and states of the parent class.
 * For example in the above program, PartTime and FullTime classes can access the behavoiur(EmpInfo) and states(firstName and lastName)
 * of their parent class Employee. 
 
    Syntax for Inheritance is 
    class <childClassName> : <parent/baseClassName>
    {
        //child class states and Behaviours.
    }


                                                #### METHOD HIDING ####
                                                
    Suppose from the above example we have EmpInfo() method with basic employee information but we want to show extra information for  
    PartTime employees. In that case we can have another method EmpInfo in PartTime class. Now when the object calls the method the method 
    in partTime class will hide the parent class method. 
    
    HOWEVER the important point to note here is that, that a base class reference variable can point to child class object (because a
    child class all the features of base class). And in this case the object will refer to base class states and behaviours not child class 
    as the reference variable is base class type. 

    i.e baseClass <referencevariablename> = new <childClassConstrctor()>  --> valid
    ex: Employee obj = new PartTime();                                    --> valid

    
    MOREEVER it cannot be done the other way around as the base class does not have all the states and behaviours of the child class 
    hence cannot perform all its functions. 
    
    i.e PartTime obj = new Employee();     --> Invalid  
     
     */