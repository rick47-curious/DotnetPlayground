using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPlayground
{
    public class ParentClass
    {
        protected int MyProperty { get; } = 50;

        //Overriding
        public virtual void Caller()
        {
            Console.WriteLine("Invoked from Caller method of parent class");
        }

        public void EmptyCaller() 
        {
            Console.WriteLine("Empty Caller from Parent");
        }
    }
}
