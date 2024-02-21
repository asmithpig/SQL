namespace Assignment_3;

public static class FibonacciSequence
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{Fibonacci(i)} ");
        }
        Console.WriteLine();
    }

    private static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        int a = 1;
        int b = 1;
        for (int i = 2; i < n; i++)
        {
            (a, b) = (b, a + b);
        }

        return b;
    }
}