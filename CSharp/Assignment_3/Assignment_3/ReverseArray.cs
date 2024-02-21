namespace Assignment_3;

public static class ReverseArray
{
    public static void Main() {
        int[] numbers = GenerateNumbers(10); 
        Reverse(numbers); 
        PrintNumbers(numbers);
    }

    private static int[] GenerateNumbers(int length = 10)
    {
        int[] ret = new int[length];
        for (int i = 0; i < length; i++)
        {
            ret[i] = i + 1;
        }
        return ret;
    }

    private static void Reverse(int[] numbers)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
    }

    private static void PrintNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            Console.Write($"{numbers[i]}, ");
        }
        Console.WriteLine(numbers[numbers.Length - 1]);
    }
}