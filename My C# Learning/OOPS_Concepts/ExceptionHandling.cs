using System;
using System.IO;

namespace MyNameSpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StreamReader readThisFile = null;

            try
            {
                readThisFile = new StreamReader(@"C:\Users\harry\Desktop\exitNotesPalette.txt");
                Console.WriteLine(readThisFile.ReadToEnd());
            }
            catch (FileNotFoundException excep)
            {
                Console.WriteLine("EXP1: Cannot find file: " + excep.FileName);
            }
            catch (DirectoryNotFoundException excep)
            {
                Console.WriteLine("EXP2: " + excep.Message);
            }
            catch (Exception excep)
            {
                Console.WriteLine("EXP3: " + excep.Message);            
            }
            finally
            {
                if(readThisFile != null)
                    readThisFile.Close();
                Console.WriteLine("Finally");
            }
            Console.Read();
        }
    }
}


/*
    :::::::::::::::::EXCEPTION HANDLING::::::::::::::::

    Whenever we have an unforseen error that the application was not expecting, we get an Exception. (for ex: while opening a file we expect the file to be present)
    A good application should be capable of handling exception. In above code we are trying to open a file and read it in console application. But what if the file 
    name/path is not correct or if someone has changed it. Similarly while reading from the database if the table is not there or something like that goes wrong, our
    program should be capable of handling such exceptions.

    First lets see WHAT IS AN EXCEPTION??
    -> An exception is a class that derives from System.Exception Class under System base class library. There are other Exception classes that are specification of the 
    Exception class like FileNotFoundException,DirectoryNotFoundException etc. Each of these classes directly or indirectly inherits from Exception class.
    
    ******IMP:::: Exception class is super base class for all other specific exception classes
    
    WHY WE SHOOULD HANDLE EXCEPTIONS???
    -> Its annoying for end user to see them, as they are not familier with the technical language it may be in. 
    -> It stops or crashes the application.
    -> It holds on to resources which must be released.
    -> It gives valuable information to hackers who can use it to hack into the application.
    
    Now to handle an exception we can use something like try-catch-finally. 
    Syntax:  try{
                    // Something that might give an exception. Our program:: Open a file in our case. -->> line 14
                }
           catch{
                    // What to do if exception occurs, like log data to log files or database.  Our program:: Give out a meaningful message. -->> line 19 and 23
                }
         finally{
                    // Do this regardless there is an exception or not. Our program:: free up resources(close StreamReader). -->> line 31 and 32.
                }
    
    So even if there is an exception we are not holding on to resources and not giving out valueable information to the bad guys.  


    NOTE:: The class Exception is most generic exception class and covers all the exceptions that could occur. But the information about the exception it provides is 
    limited. Therfore any special exception handling must be called before calling general exception handling. 
    For example: in above code example we called FileNotFoundException and DirectoryNotFoundException class exceptions before calling Exception class object. Not doing so 
    will give a compilation error.


	Now that we know what is an exception and how to handle it, we need to make sure we are using it when we have no other way i.e. we are not doing "EXCEPTION 
	HANDLING ABUSE".

	What is Exception Handling Abuse? 
	We should always try that an Exception does not occur at the first place, rather than allowing it to take place and then handle it. For Example: In the above
	program rather tan allwoing the file not found exception to occur we should check if the file exists before trying to read from it. 
	This can be done by a simple if-else logic and we can print appropriate messages rather than using exceptions.
	The above program can be re-written as:

using System;
using System.IO;

namespace MyNameSpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StreamReader readThisFile = null;
            string filePath = @"C:\Users\harry\Desktop\exitNotesPaette.txt";
            if (File.Exists(filePath))
            {
                readThisFile = new StreamReader(filePath);
                Console.WriteLine(readThisFile.ReadToEnd());
            }
            else
            {
                Console.WriteLine("ERROR:: Something is wrong with file path or name.Please check again");
            }
            if (readThisFile != null)
                readThisFile.Close();
            Console.Read();
        }
    }
}

So the bottom line is do not use exceptions until needed.

*/
