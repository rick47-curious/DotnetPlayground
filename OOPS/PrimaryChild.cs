
namespace DotnetPlayground.OOPS
{
    public class PrimaryChild(string name, int age) : PrimaryConstructor(name,age)
    {
        //Explicit constructor invoking the primary constructor using this keyword
        public PrimaryChild(int num,string name,int age) : this(name, age) 
        {
            Console.WriteLine($"Num: {num} Name: {name} Age: {age}");
        }
}
}
