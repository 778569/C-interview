public class HelloWorldReadOnly
{
    public readonly string name = "Kathryn";

    public HelloWorldReadOnly(string name) {
        this.name = name;
    }

    public static void Main(string[] args)
    {
        HelloWorldReadOnly helloWorldReadOnly = new HelloWorldReadOnly("Sara");
        Console.WriteLine(helloWorldReadOnly.name);
    }
}
