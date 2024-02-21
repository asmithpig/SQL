namespace Assignment_3.ColorBall;

public static class Demo
{
    public static void Main()
    {
        Color color1 = new Color(255, 128, 218);
        Color color2 = new Color(10, 33, 255);
        
        Ball ball1 = new Ball(80, color1);
        Ball ball2 = new Ball(120, color2);
        
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        ball1.Pop();
        ball1.Throw();
        ball2.Throw();
        
        Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");
        Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");
    }
}