namespace Assignment_3.ColorBall;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    public Ball(int size, int red, int green, int blue, int alpha = 255)
    {
        this.size = size;
        this.color = new Color(red, green, blue, alpha);
        this.throwCount = 0;
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}