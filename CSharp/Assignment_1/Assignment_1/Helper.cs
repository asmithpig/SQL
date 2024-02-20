namespace Assignment_1;

public static class Helper {
    public static void PlayingWithConsoleApp()
    {
        Console.WriteLine("what's your favorite color?");
        string? favoriteColor = Console.ReadLine();
        Console.WriteLine("What's your astrology sign？");
        string? astrologySign = Console.ReadLine();
        Console.WriteLine("What's your street address number？");
        string? streetAddressNumber = Console.ReadLine();
        Console.WriteLine($"Your hacker name is {favoriteColor}{astrologySign}{streetAddressNumber}.");
    }
    
    public static void PracticeNumberSizesAndRanges1()
    {
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "Data Type", "Bytes", "Minimum Value", "Maximum Value");
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-10}| {1,-10} {2,-40} {3,-40}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }

    public static void PracticeNumberSizesAndRanges2(int centuries)
    {
        decimal years = (decimal) centuries * 100;
        decimal days = years * 365 + years / 4 - years / 100 + years / 400;
        decimal hours = days * 24;
        decimal minutes = hours * 60;
        decimal seconds = minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;
        Console.WriteLine($"Input: {centuries}");
        Console.WriteLine($"Output: {centuries} centuries = {Decimal.Truncate(years)} years = {Decimal.Truncate(days)} days = {Decimal.Truncate(hours)} hours = {Decimal.Truncate(minutes)} minutes = {Decimal.Truncate(seconds)} seconds = {Decimal.Truncate(milliseconds)} milliseconds = {Decimal.Truncate(microseconds)} microseconds = {Decimal.Truncate(nanoseconds)} nanoseconds");
    }

    public static void FizzBuzz(int turns)
    {
        Console.WriteLine("Fizzbuzz game: ");
        for (int i = 1; i <= turns; i++) 
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void GuessNumber()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number between 1 and 3!");
        while (true)
        {
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("You get the correct answer.");
                break;
            }
            else if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine(
                    "Answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3)!");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("High.");
            }
            else
            {
                Console.WriteLine("Low.");
            }
        }
    }

    public static void PrintPyramidLikeStarPattern(int rows)
    {
        Console.WriteLine($"Print a pyramid like star pattern with {rows} rows!");
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < rows - i - 1; j++) 
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++) 
            {
                Console.Write("**");
            }
            Console.WriteLine("*");
        }
    }

    public static void DaysOldAnniversary(DateTime birthday)
    {
        int days = (DateTime.Today - birthday).Days;
        Console.WriteLine("This person is {0} days old.", days);
        int daysToNextAnniversary = 10000 - (days % 10000);
        Console.WriteLine($"{daysToNextAnniversary} days until this person's next 10,000 day (about 27 years) anniversary.");
    }

    public static void Greetings(DateTime dateTime)
    {
        if (dateTime.Hour < 6 || dateTime.Hour > 21)
        {
            Console.WriteLine("Good Night");
            return;
        }
        if (dateTime.Hour < 12)
        {
            Console.WriteLine("Good Morning");
            return;
        }
        if (dateTime.Hour < 18)
        {
            Console.WriteLine("Good Afternoon");
            return;
        }
        Console.WriteLine("Good Evening");
    }

    public static void CountingTo24()
    {
        for (int i = 1; i <= 4; i++) 
        {
            for (int j = 0; j <= 24; j += i) 
            {
                Console.Write(j);
                if (j < 24)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}