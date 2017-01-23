using System;
namespace MainSpace
{
    class MainClass
    {
        static void Main()
        {
            int value = 0;
            AddNameSpace.AddClass obj = new AddNameSpace.AddClass();    // Add Class object. 
            obj.add(6, out value);                                      // pass parameters for any of the add method.
            Console.ReadLine();
        }
    }
}

namespace AddNameSpace
{
    class AddClass                                                       // Contains 3 methods named "add" but with different signatures. 
    {
        public void add(int i, out int j)
        {
            int sum = i ;
            j = sum;
            Console.WriteLine("Sum is :" + j);
        }

        public int add(int k,int l)
        {
            int sum = k + l;
            Console.WriteLine("Sum is :" + sum);
            return sum;
        }
        public float add(float k, int l, int x)
        {
            var sum = k + l + x;
            Console.WriteLine("Sum is :" + sum);
            return sum;
        }
    }
}


/* -------------####### METHOD OVERLOADING #######-------------
 Method overloading is having two or more methods with the same name, but it have to have a different signature. 

    What is a Signature?  A signature is method declaration including method name and parameters, but not return type or access modifiers.
                          for example in ----public void Print(int i, float j)----     Print(int i, float j) is method signature. 

 How a signature can be different??  
 1. Have different method name.(but that wont be method overloading)
 2. Have differnt "number" of parameters. for ex Add(int i) and Add(int i, int j) -- different NUMBER OF parameters.
 3. Have different "kind" of parameters.i.e reference type, value type, output type
 for ex:1. Add(int i) and Add(ref int i) -- different KIND OF parameters.
        2. Add(int i, flaot j) and Add(int i, out float j) -- different KIND OF parameters.
 4. Have  differnet "type" of parameters: i.e different data type - int, flaot , char etc. 
    for ex: 1. Add(int i) and Add(float i) -- different TYPE OF parameters.
                                              
  NOTE:: "params" modifier and return type alone cannot be used to overload methods().
      
 */
