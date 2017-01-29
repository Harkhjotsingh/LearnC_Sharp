using System;
using System.IO;
namespace MyNameSpace
{
    class MainClass
    {
        // Method to log Exceptions into a log file
        static void WriteLogs(Exception exceptionParameter, string pathOfFile)              // takes the exception that has to loged and file where it has to be logged.
        {
            StreamWriter sw = new StreamWriter(pathOfFile);                                 // Stream writer object.
            sw.WriteLine("Type of Excpetion: " + exceptionParameter.GetType().Name);        // Logs the type of the exception.
            sw.WriteLine("Exception Message: " + exceptionParameter.Message);               // Logs the exception message thrown by the Exception class.
            sw.Write("Line of exception: " + exceptionParameter.StackTrace);                // Exactly on which solution/project/file/line the exception has occured.
            sw.Close();                                                                     // Free the resources.
        }

        static void Main(string[] args)
        {
            try                                                                             // Outer try and catch.
            {
                try                                                                         // Inner try and catch.
                {
                    Console.Write("Enter first number: ");
                    uint firstNum = uint.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    uint secondNum = uint.Parse(Console.ReadLine());
                    uint res = firstNum / secondNum;
                    Console.WriteLine("Division result is: " + res);
                }
                catch (Exception excp)                                                       // Inner catch.
                {
                    string filePath = @"C:\Users\harry\Desktop\LogFiles.txt";
                    if (File.Exists(filePath))
                    {
                        WriteLogs(excp, filePath);
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present",excp);                                                        // Not passing exceptoin object eill result in its value as null. And we cannot print inner exception. 
                    }
                    Console.WriteLine("Well we have a problem");
                }
            }
            catch(Exception excptn)                                                           // Outer catch.                   
            {
                Console.WriteLine("Current Exception: " + excptn.GetType().Name +"  Exception Message: "+ excptn.Message);                           // Print Current(outer) Exception
                if(!(excptn.InnerException == null))                                                                                                 // Check if Inner exception object is not null.   
                Console.WriteLine("Inner Exception: " + excptn.InnerException.GetType().Name +"Exception Message: "+excptn.InnerException.Message);  // Print Inner Exception  
            }

            Console.Read();
        }
    }
}


/*
    :::::::::::::::::INNER EXCEPTION :::::::::::::::: OK this is Tricky.

    Lets assume we want to catch an Exception and log in to a log file. See line 30-36, ignore line 33.
    Now lets say this works great and we had overflow exception and it got logged in to the log file. Someone check it and fixed the problem but that idiot changed the log file name or directory.
    
    Now lets say the overflow exception occurs again but the file does not exist on the given path anymore.This will result into another exception FileNotFoundException().
    Since we're good programmers we try to handle as many exceptions as possible. So we put another exception handler, an outer try-catch block. See the code comments above to make sense of it. Also try to 
    figure out the sequence of code i.e what is written when.
    
    Here, in our case the current exception will be FileNotFoundException(). See line 39. But the overflow exception that occured earlier that we wanted to log is called INNER EXCEPTION.
    Now that we know what an Inner Exception is, we can print it out along with current exception in outer catch block. see lines 44 to 49. 
    
    NOTE: Also dont forget to check whether the inner Exception object is Null, otherwise it will throw another Exception. see line 47.   

*/
