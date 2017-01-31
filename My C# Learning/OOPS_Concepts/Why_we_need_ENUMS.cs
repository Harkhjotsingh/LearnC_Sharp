using System;
using System.IO;

namespace EnumsSpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Students[] stu = new Students[3];
            stu[0] = new Students { Name = "Harry", courseMajorName = 1 };
            stu[1] = new Students { Name = "Simmy", courseMajorName = 4 };
            stu[2] = new Students { Name = "Gibrish", courseMajorName = 3 };

            foreach (Students student in stu)
            {
                Console.WriteLine("Student name is: " + student.Name + " Student selected: "+ GetCourseMajorName(student.courseMajorName));
            }
            Console.Read();
        }
        public static string GetCourseMajorName(int courseMajorNumber)
        {
            switch(courseMajorNumber)
            {
                case 0:
                    return "Law";
                    break;
                case 1:
                    return "Enginnering";
                    break;
                case 2:
                    return "Science";
                    break;
                case 3:
                    return "Arts";
                    break;
                case 4:
                    return "Commerce";
                    break;
                default:
                    return "Invalid entry";      
            }
        }
    }

    
    public class Students
    {
        public string Name { get; set; }
        public int courseMajorName { get; set; }  //0:- Law  1:- Enginnering 2:- Science 3:- Arts  4:-Commerce  
    }
}

/*              
        ------------ WHY WE NEED ENUMS -------------
   Above is the simple program that prints Name and cource-Major of a Student. But the course majors have some numbers associated with them. for example
   0 is for La
   1 is for Enginnering. 
   2 is for Science. and so on ..

   And we have a GetCourseMajorName() method that defines this relation. 
   
    But if we go to line 11,12 and 13 we cannot say what 1,3 or 4 means just by looking at them or unless we have a support document. 
    Also we the course numbers increases to a certain number (say 50+), even refereing to a document becomes pain in the neck. Its even hard to keep track of
    the numbers. 
    So the problem here is code "READABILITY" and "MAINTENANCE."
    
    Here Enums comes to rescue as they provide better code readability and maintenance. 
*/
