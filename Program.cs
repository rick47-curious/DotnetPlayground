
using DotnetPlayground.DSA;
using DotnetPlayground.OOPS;

namespace DotnetPlayground 
{
    public class Program
    {

        public static void Main()
        {
            //ChildOne childOne = new(1,"Ram");

            //childOne.GetValues();

            //Console.WriteLine("Child Property value: " + childOne.BaseName);
            //childOne.CallMethod();
            //childOne.CallMethod("Henry");

            //ParentClass polymorphicObj = new ChildOne(2,"Ramesh");
            //polymorphicObj.GetValues();

            ////Polymorph
            //polymorphicObj.Caller();

            ////Not a polymorph
            //polymorphicObj.EmptyCaller();

            //Console.WriteLine("*****************************************************");
            //MyInterface intObj = new ChildTwo();

            //MyAbstractions absObj = new ChildTwo();

            //intObj.Caller();
            //intObj.DemoMethod();

            //absObj.GetNum = 30;
            //Console.WriteLine("Before : "+absObj.GetNum);

            //absObj.GetNum = 50;
            //Console.WriteLine("After: "+absObj.GetNum);

            //absObj.PrintStatement();
            //absObj.Print();

            //Console.WriteLine("**********************************************************");

            //PrimaryConstructor prmConst = new("Ada", 29);
            //Console.WriteLine("Name: "+prmConst.Name);
            //Console.WriteLine("Age: "+prmConst.Age);

            //PrimaryConstructor prmObj = new PrimaryChild("Adam", 25);
            //Console.WriteLine("Name: " + prmObj.Name);
            //Console.WriteLine("Age: " + prmObj.Age);

            //PrimaryConstructor prmObj2 = new PrimaryChild(29, "Bob", 52);
            //Console.WriteLine("Name: "+ prmObj2.Name);
            //Console.WriteLine("Age: " + prmObj2.Age);


            int[] array = [1, 2, 3, 4, 0];

            int[] array2 = [5,6,8,9,7,1,0];
            ArrayOperations arrayOperations = new();

            //arrayOperations.InsertAtLastIndex(5, array);

            arrayOperations.InsertAtFirstIndex(8, array2); 

            //arrayOperations.InsertAnyIndex(3, 9, array2);

        }
    }

}
