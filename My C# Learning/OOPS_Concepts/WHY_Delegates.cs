using System;
using System.Collections.Generic;

namespace MyName
{
    public class Mainclass
    {

        static void Main()
        {
            List<Students> studentList = new List<Students>();
            studentList.Add(new Students { SNum = 101, Name = "Harry Minhas", Marks = 78, Behaviour = 7, Sports = 6 });
            studentList.Add(new Students { SNum = 102, Name = "Simmy Minhas", Marks = 28, Behaviour = -1, Sports = 7 });
            studentList.Add(new Students { SNum = 103, Name = "Harkhjot Minhas", Marks = 48, Behaviour = 2, Sports = 8 });
            studentList.Add(new Students { SNum = 104, Name = "Simranjot Minhas", Marks = 79, Behaviour = 10, Sports = 5 });
            studentList.Add(new Students { SNum = 105, Name = "Simranjot Singh", Marks = 76, Behaviour = 0, Sports = 4 });

            Students obj = new Students();
            obj.PassOrFail(studentList);
            Console.Read();
        }
    }
    public class Students
    {
        private byte marks;
        private sbyte behaviourPoints;
        private byte sportsPoints;


        public ushort SNum { get; set; }
        public string Name { get; set; }
        public byte Marks { set { if (value >= 100) { throw new Exception("Well this is BullShit!"); } else { marks = value; } } get { return marks; } }
        public sbyte Behaviour { set { if (value < -10 || value > 10) { throw new Exception("values out of range!"); } else { behaviourPoints = value; } } get { return behaviourPoints; } }
        public byte Sports { set { if (value > 10) { throw new Exception("values out of range!"); } else { sportsPoints = value; } } get { return sportsPoints; } }

        public void PassOrFail(List<Students> stuList)
        {
            foreach (Students stu in stuList)
            {
                if ((stu.marks > 55) && (stu.behaviourPoints > 3))
                {
                    Console.WriteLine(stu.Name + " have passed the Exam");
                }
            }
        }
    }
}

/* 
    :::::: WHY DELEGATES?? ::::::
  
    In the above class Students we have defined a logic to pass or fail a student. See line -> 40. 
    Now if we want to reuse the class and its members we cannot use the PassOrFail method() as the criteria to pass or fail a student may be different for different 
    isnstitutions. Since the logic to pass or fail a student is hard codded it will not work for other schools or in case the criteria changes. 
    
    To make this class reusable we can use the logic of a delegate. Lets see how we can do that. 
    
    !!!!!!!!!!!!----- Comment out the above code upto line 47 and uncomment the below code by commenting line 62--------!!!!!!!!!!!! 
        
*/

/*
using System;
using System.Collections.Generic;

namespace MyName
{
    public class Mainclass : ConditionsForFailOrPass
    {

        static void Main()
        {
            List<Students> studentList = new List<Students>();
            studentList.Add(new Students { SNum = 101, Name = "Harry Minhas", Marks = 82, Behaviour = 7, Sports = 9 });
            studentList.Add(new Students { SNum = 102, Name = "Simmy Minhas", Marks = 56, Behaviour = 4, Sports = 5 });
            studentList.Add(new Students { SNum = 103, Name = "Harkhjot Minhas", Marks = 48, Behaviour = 2, Sports = 8 });
            studentList.Add(new Students { SNum = 104, Name = "Simranjot Minhas", Marks = 79, Behaviour = 5, Sports = 5 });
            studentList.Add(new Students { SNum = 105, Name = "Simranjot Singh", Marks = 76, Behaviour = 0, Sports = 4 });

            ShouldPassOrFail criteriaToPass1 = new ShouldPassOrFail(Condition2);
            ShouldPassOrFail criteriaToPass2 = new ShouldPassOrFail(Condition1);
            Students obj = new Students();
            obj.PassOrFail(studentList, criteriaToPass2); Console.WriteLine("-------------------------"); obj.PassOrFail(studentList, criteriaToPass1);    // used same line because I already mentioned line numbers in the comments below.
            Console.Read();
        }
    }


public delegate bool ShouldPassOrFail(Students student);

public class ConditionsForFailOrPass
{
    public static bool Condition1(Students stu)
    {
        if ((stu.Marks >= 55) && (stu.Behaviour >= 3))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool Condition2(Students stu)
    {
        if ((stu.Marks >= 80) && (stu.Sports >= 9) || (stu.Marks >= 30) && (stu.Sports >= 7))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Students
{
    private byte marks;
    private sbyte behaviourPoints;
    private byte sportsPoints;


    public ushort SNum { get; set; }
    public string Name { get; set; }
    public byte Marks { set { if (value >= 100) { throw new Exception("Well this is BullShit!"); } else { marks = value; } } get { return marks; } }
    public sbyte Behaviour { set { if (value < -10 || value > 10) { throw new Exception("values out of range!"); } else { behaviourPoints = value; } } get { return behaviourPoints; } }
    public byte Sports { set { if (value > 10) { throw new Exception("values out of range!"); } else { sportsPoints = value; } } get { return sportsPoints; } }

    public void PassOrFail(List<Students> stuList, ShouldPassOrFail isElegibleToPass)
    {
        foreach (Students stu in stuList)
        {
            if (isElegibleToPass(stu))
            {
                Console.WriteLine(stu.Name + " have passed the Exam");
            }
        }
    }
}
}


/* 
    Now things have become little complicated, lets understand it step by steps.

    STEP1: Declare a Delegate that takes an object of the framework class(Students Class). -->> see line 89.
    STEP2: Pass the delegate as a Parmeter to PassOrFail method(). -->> see line 132.
    STEP3: Use the delegate parameter to define the logic for pass and fail in PassOrFail() method. -->> see line 136.
    STEP4: Now we will get an error in StudentClass object where we calles PassOrFail method(), since we added a parameter. Now this is important.
             WE HAVE TO PASS THE DELEGATE OBJECT here, THAT IS POINTING TO A METHOD,THAT HOLDS THE LOGIC. 
    STEP5: Now lets create a function(s) that the delgate is going to point to. For this we have created a class ConditionsForFailOrPass with several condition methods.
    see line -->> 91 to 116. 
    STEP6: Create a delegate obeject in Main() and point to one of these condition methods. -->>see line 81.
    STEP7: Pass this delegate object as a parameter to instance to PassOrFail() method in Main() method. 

    Now you're passing the same list of students to the instance of PassOrFail() method but the criteria/logic the method uses to pass or fail a student is defined
    somewhere else not in the PassOrFail() method itself. Therefore we can use the same isntance of Student Class and its methods to do the job. The only thing we need
    to change is the delegate object(which actaully points to the method that holds the logic).   

*/
