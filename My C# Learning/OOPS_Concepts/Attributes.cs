using System;
using System.Collections.Generic;

namespace Attributes
{
    public class MainClass
    {
        static void Main()
        {
            Claculator cal = new Claculator();
            float res =  cal.Add(5,5);
            Console.WriteLine("Sum is " + res);

            float result = cal.Add( new List<float>() {5,8,7.8f,5} );
            Console.WriteLine("Sum is " + result);
            Console.Read();
        }
    }

    public class Claculator
    {
        [Obsolete("Use method Add(List<float> numbers)",false)]
        public float Add(float firstNum, float secondNum)
        {
            return firstNum + secondNum;
        }
        public float Add(List<float> numbers)
        {
            float sum = 0;
            foreach(float num in numbers)
            {
                sum += num; 
            }
            return sum;
        }
    }   
}

/* 
    **********************************************************ATTRIBUTES******************************************************
    An Attribute allows the programmer to add decorative information to the method, this information can be known at runtime using reflection. 
    For now, let's just understand the first part i.e it allows us to add a decorative information to the method.
    
    -> Suppose we have a scenario where we have a functionality and a method associated with it. But after a while, we need to update that functionality and we had
    another method overload. We cannot update the same method as some people may be using it and it may break for them, or they just like it that way.-Backward
    compatibility. 
    -> From the above example, we have an add method that adds two numbers,(line 23). Observe that it can only add two numbers, which is not sufficient anymore 
    for some reason. So we have another method Add which can take a list of numbers and add them(line 27).
    
    Now the problem is we want to tell the user and another programmer that a new better method is available. 
    This can be done using Attributes, as they allow us to add "decorative information to a method".
    --> See line 22, we have added an Attribute "Obsolete" with a message "Use method Add(List<float> numbers)". That is whenever add method is called the 
    compiler will generate a warning, saying ****Calculator.Add(float, float)' is obsolete: 'Use method Add(List<float> numbers)'****
    
    Also if we want to make force the user to use another method we can make the second parameter of the “ObseleteAttribute” as true, this will generate an error
    instead of a warning.      

    This way we can keep both methods and also notify. Here obsolete is just one of the Attributes.

*/
