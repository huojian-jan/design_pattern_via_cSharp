
class Program
{
    static void Main(string[] args)
    {
        var a=100;
        var b=50;

        var sum=Add(a,b);
        var diff=Subtract(a,b);

        Console.WriteLine("Sum: "+sum);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }
}