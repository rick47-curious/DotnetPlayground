
namespace DotnetPlayground
{
    public interface MyInterface
    {
        
        void Caller() 
        {
            Console.WriteLine("From interface , caller method");
        }

        //Unimplemented method
        void DemoMethod();
    }
}
