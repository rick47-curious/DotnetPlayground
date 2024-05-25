
namespace DotnetPlayground 
{
    public class Program
    {

        public static void Main()
        {
            ChildOne childOne = new();

            Console.WriteLine("Child Property value: " + childOne.BaseName);
            childOne.CallMethod();
            childOne.CallMethod("Henry");

            ParentClass polymorphicObj = new ChildOne();
            //Polymorph
            polymorphicObj.Caller();

            //Not a polymorph
            polymorphicObj.EmptyCaller();
            
        }
    }

}
