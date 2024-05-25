
namespace DotnetPlayground
{
    public abstract class MyAbstractions
    {
        public abstract void PrintStatement();

        public abstract int GetNum { get; set; }

        public void Print() 
        {
            Console.WriteLine("From non-abstract print method");
        }
    }
}
