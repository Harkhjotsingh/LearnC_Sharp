using System;
using System.IO;

namespace EnumsSpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Students[] stu = new Students[3];
            stu[0] = new Students { Name = "Harry", courseName = CourseMajorName.Enginnering };
            stu[1] = new Students { Name = "Simmy", courseName = CourseMajorName.Commerce };
            stu[2] = new Students { Name = "Gibrish", courseName = CourseMajorName.Arts };

            foreach (Students student in stu)
            {
                Console.WriteLine("Student name is: " + student.Name + " Student selected: "+ GetCourseMajorName(student.courseName));
            }
            Console.Read();
        }
        public static string GetCourseMajorName(CourseMajorName course)
        {
            switch(course)
            {
                case CourseMajorName.Law:
                    return "Law";
                    break;
                case CourseMajorName.Enginnering:
                    return "Enginnering";
                    break;
                case CourseMajorName.Science:
                    return "Science";
                    break;
                case CourseMajorName.Arts:
                    return "Arts";
                    break;
                case CourseMajorName.Commerce:
                    return "Commerce";
                    break;
                default:
                    return "Invalid entry";      
            }
        }
    }

    public enum CourseMajorName
    {
        Enginnering,
        Science,
        Arts,
        Commerce,
        Law
    }


    public class Students
    {
        public string Name { get; set; }
        public CourseMajorName courseName { get; set; }  //0:- Law  1:- Enginnering 2:- Science 3:- Arts  4:-Commerce  
    }
}

/*              
        ------------ ENUMS IMPLIMENTATION -------------
    This is the same example from Why_we_need_ENUMS, and serves exactly the same purpose for instead we have implimented an ENUM here.-->> see line 46
    It has a simple syntax of comma(,) seperated members with a block.
    
    REMEMBER Enums are value type and can be used as a type. So here we made the courseName property as CourseMajorName enum type. This means this property can
    only have values/members defined in this enum. 
    Instead of passing the number like we did before we can pass the <enumName.memberName> istead. -->> see Main() and GetCourseMajorName() method. 

    Notice that the code is more readable now, just by looking a line 11,12 and 13 we can tell the course name of the student. 
    Also if the scale of this program increases to accomodate more courses like agriculture,politics etc. Its much more easily maintainble.


    NOTES:: Some extra information on Enums:
    1. Enums are value type.
    2. There is a base class library in .NET named "Enum". On the other hand "enum" is the key word used to declare Enums. 
    3. By default data type Enums is "int". But it can be changed. Syntax is <accessModifier> enum <enumName> : <datatype>
                                                                        ex:   public enum Gender : byte
    4. By default the number associated with fisrt element is 0 and gets increment by 1. But it can be changed and dosent have to in any form of sequence. 
    for ex: public enum Gender : byte
            {
                Male = 10;
                female = 20;
            }        

    The only thing is that the numbers must be in the range of the type.
         for ex:
          public enum Gender : byte
            {
                Male = 10;                 // valid
                female = 500;              // invalid. Since the max value byte can hold is 255. 
            }  
    
    5. We cannot directly assign a number to enum Element outside of it without an explicit cast. 
       for ex:
                Gender xyz = 3;            // invalid. It needs to be Typecasted with enum type (remember enum is a value type)
                Gender xyz = (Gender)3;    // valid. Casted to enum type.                                
    6. Similarly like above we cannot assign enum to numbers directly without casting.
        for ex:
                int number = Gender.unknown;                    // invalid. It needs to be Typecasted with enum Int32
                int number = Convert.ToInt32(Gender.unknown);   // Valid. Casted to int type. 
    
    7. Because of point 5 and 6 enums are called Strongly type constants.
 */
