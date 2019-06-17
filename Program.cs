using System;

namespace PrivateAccessModifier
{
    static class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Parent();

            // obj.value = 5; 
            // Also gives an error 

            // Use public functions to assign 
            // and use value of the member 'value' 
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
        }
    }
}
