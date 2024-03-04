public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine("Num outside function: " + n);
        square(ref n);
        Console.WriteLine("Num outside function: " + n);
    }

    public static void square(ref int num) {
        num = num * num;
        Console.WriteLine("Num inside function: " + num);
    }
}
