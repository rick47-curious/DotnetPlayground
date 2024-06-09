
namespace DotnetPlayground
{
    public class ParentClass
    {
        private int count;
        private string name;

        public ParentClass(int count,string name) 
        {
            this.count = count;
            this.name = name;
        }

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

        public void GetValues() 
        {
            Console.WriteLine($"Count: {count} and Name: {name}");
        }
    }
}
