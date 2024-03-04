public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine("Num outside function: " + n);
        square(n);
        Console.WriteLine("Num outside function: " + n);
    }

    public static void square(int num) {
        num = num * num;
        Console.WriteLine("Num inside function: " + num);
    }
}
