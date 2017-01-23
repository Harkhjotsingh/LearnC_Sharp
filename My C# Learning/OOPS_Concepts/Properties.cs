// Properties Example. 

using System;
namespace MyName
{
    class Student
    {
        private uint stuId;
        private string stuName;
        private uint passingMarks = 33;

        public string House { get; set; }                  //Auto-Implemented Properties
        public string Interest { get; set; }
        public uint Id
        {
            set
            {
                if (value <= 0)                          /* value keyword will take the value which is set to the field.*/
                {
                    throw new Exception("Student Id should be non-zero and positive");
                }
                else { stuId = value; }                 /* field = value -->(value has the actual value/parameter passed)*/                
            }
            
            get{ return stuId; } 
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name cannot be null");
                }
                else { stuName = value; }
            }
            get
            {
                return stuName;
            }
        }

        public uint passMarks
        {
            get { return passingMarks; }           
        }
    }
class MainClass
    {
        static void Main()
        {
            Student stu1 = new Student();
            stu1.Id = 54;
            stu1.Name = "Harry";
            stu1.House = "I believe its a meaningless thing";
            stu1.Interest = "Too many to begin with";
            Console.WriteLine("Student id is: "+stu1.Id);
            Console.WriteLine("Student name is: " + stu1.Name);
            Console.WriteLine("Student house is: " + stu1.House);
            Console.WriteLine("Student interests are: " + stu1.Interest);
            Console.WriteLine("Passing Marks are: " + stu1.passMarks);

            Console.ReadLine();
        }
    }
}

/* Why we need Properties??
    --> To control what goes into and out to class fields. For exapmle suppose we have a class called Employee and fields like empNo,
    emoName,empSal etc. Now if these fields are public anyone can assign anything to these fields, but an empNo cannot be 0 or negative,
    empName must have last name, empSal must be positive and more than a certain amount. So like here we may have rules and requirements 
    like that.
    
    Therefore to have CONTROL OVER THE WHAT GOES IN AND OUT OF THESE FIELD we use Properties.
    Step1: First of all we need to make these fields as private so that they cannot be accessed/modified outside of the class directly. 
    Step2: Declare a property. A property generally have "set" and "get" accessers. SET is used to assign values to the field and GET is
    used to retrieve them. Syntax : <accessModifier><datatypeOfField> <propertyName>
                                                {
                                                  set { 
                                                         //Condition if any
                                                         field = value;     // here value is keyword. 
                                                      }
                                                  get
                                                  {
                                                    return field;
                                                  }  
                                                }      

    In above  program see example for stuId (property Id) and stuName (propertyName)
    
    What if we dont have condition for a field, for example emoPhno where phone number is optional and can be null or empty.??
    Then we can declare it the same way but that's a lot of code to write for lazy people like us. 
    Here we can make use of "AUTO-IMPLEMENTED" properties. 
    syntax: 
                                    <accessModifier> <datatypeOfField> <propertyName>
                                                {
                                                  set;
                                                  get;
                                                } 
     No need to define fields seperately and define get and set blocks. Its done automatically. 
     In above  program see example for House (property Id) and Interest (propertyName)


############################################################################################################################################################
############################################################################################################################################################
###################################### PROTECTING THE FIELDS LIKE THIS USING PROPERTIES IS CALLED ENCAPSULATION ############################################
############################################################################################################################################################
############################################################################################################################################################
 */
