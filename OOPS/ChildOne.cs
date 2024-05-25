using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPlayground
{
    public class ChildOne : ParentClass
    {
        public ChildOne() 
        {
            Console.WriteLine("Access parent property: "+MyProperty);
        }

        //Property
        public string? BaseName { get; } = "demo";

        //Overriding
        public override void Caller() 
        {
            Console.WriteLine("Invoked from Caller method of childone class");
        }

       
        public new void EmptyCaller() 
        {
            Console.WriteLine("Empty caller from child");
        }

        //Overloading
        public void CallMethod() 
        {
            Console.WriteLine("Invoked from CallMethod");
        }

        public void CallMethod(string name = "abcd") 
        {
            Console.WriteLine($"Hello Mr/Ms {name}");
        }
    }
}
