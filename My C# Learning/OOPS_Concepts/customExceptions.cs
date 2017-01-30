using System;
using System.IO;
using System.Runtime.Serialization;
namespace Myname
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in. No need to login again");
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //int res = a/b;
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine("Type: " + ex.GetType());
                Console.WriteLine("Additional Info: " + ex.Message);
            }
            catch(Exception excep)
            {
                Console.WriteLine("Type: "+excep.GetType());
                Console.WriteLine("Additional Info: " +excep.Message);
            }
            Console.Read();   
        }
    }

[Serializable]                                                                     // Making the Exception Class Serializable.                
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()                             // Constructor overloading with base class Constructor.
        {
        }

        public UserAlreadyLoggedInException(string message) : base(message)         
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo information, StreamingContext context) : base(information, context)
        {
        }
    }
}


/*
        ####################  CUSTOM EXCEPTIONS  ######################

    Although .NET has many system defined exceptions, but there may be a situation where we have to define our own custom Exceptions. 

    Before we start doing that there are certain things we should keep in mind. 
    1. An Exception is basically a class that directly or indirectly inherits from the base Exception class.
    2. Every exception class is ended with Excetion suffix(like IndexerOutOfRangeException, FileNotFoundException etc) so that we can easliy identify
       that its an Exception class. 
 
    Now lets take a scenoario of a user who tries to login in a different window when he/she is already logged-in in another window. This will cause an 
    Exception, lets call it "UserAlreadyLoggedInException". 

    Steps to create a custom Exception: 
    1. Declare a class with appropriate name with Exception Suffix. -->> see line 32.
    2. Inherit from base Exception class. (This depends on the requirement and type of exception, if inheriting from some other exception class make your job
       easier, go ahead with that. The bottom line is your class should inherit from the base Exception class directly or indirectly.)
    3. Declare the constructors depending on the requirement. Constructor overloading comes really handy here, as we can use the predefined functionality 
       from system defined Exception class constructors. -->> see line 34,38,42 and 46.
    4. When using your custom exception dont forget to handle it properly. -->> see line 10-21. 

    NOTE:: At this moment I dont fully understand Serialization. I'll update the notes when I know what it is exactly. 

*/
