
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

            Console.WriteLine("*****************************************************");
            MyInterface intObj = new ChildTwo();

            MyAbstractions absObj = new ChildTwo();

            intObj.Caller();
            intObj.DemoMethod();

            absObj.GetNum = 30;
            Console.WriteLine("Before : "+absObj.GetNum);

            absObj.GetNum = 50;
            Console.WriteLine("After: "+absObj.GetNum);

            absObj.PrintStatement();
            absObj.Print();
            
        }
    }

}
