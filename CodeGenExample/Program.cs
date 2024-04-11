namespace CodeGenExample;

static partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey World");

        var mc1 = new MyClass1();
        var mc2 = new MyClass2();
        var mc3 = new MyClass3();

        HelloFrom(mc1);
        HelloFrom(mc2);

        HelloFrom(mc3);
    }

    static partial void HelloFrom(object obj);
}

public class MyAttribute : Attribute
{

}

[My]
public partial class MyClass1
{
    private readonly int _a = 1;
}

[My]
public partial class MyClass2
{
    private readonly int _a = 2;
}

[My]
public partial class MyClass3
{
    private readonly int _a = 2;
}
