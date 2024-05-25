using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPlayground
{

    //Note : Abstraction comes before interfaces
    public class ChildTwo : MyAbstractions, MyInterface
    {

        private int num;
        public override int GetNum
        {
            get
            {
                return num;
            }
            set 
            {
                num = value;
            }
        }

        
        public override void PrintStatement()
        {
            Console.WriteLine("Print statement implementation");
            Print();
        }

        public void DemoMethod()
        {
            Console.WriteLine("Message from Demo method");
        }
    }
}
