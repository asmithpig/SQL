using System.ComponentModel.DataAnnotations;

namespace Assignment_3.ColorBall;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha)
    {
        SetColor(red, green, blue, alpha);
    }

    public Color(int red, int green, int blue)
    {
        SetColor(red, green, blue, 255);
    }
    
    public void SetRed(int red) {
        if (red >= 0 && red <= 255)
        {
            this.red = red;
        }
        else
        {
            throw new ArgumentException("Invalid color values, must be in range 0 ~ 255.");
        }
    }

    public int GetRed()
    {
        return red;
    }

    public void SetGreen(int green)
    {
        if (green >= 0 && green <= 255)
        {
            this.green = green;
        }
        else
        {
            throw new ArgumentException("Invalid color values, must be in range 0 ~ 255.");
        }
    }

    public int GetGreen()
    {
        return green;
    }

    public void SetBlue(int blue)
    {
        if (blue >= 0 && blue <= 255)
        {
            this.blue = blue;
        }
        else
        {
            throw new ArgumentException("Invalid color values, must be in range 0 ~ 255.");
        }
    }

    public int GetBlue()
    {
        return blue;
    }

    public void SetAlpha(int alpha)
    {
        if (alpha >= 0 && alpha <= 255)
        {
            this.alpha = alpha;
        }
        else
        {
            throw new ArgumentException("Invalid color values, must be in range 0 ~ 255.");
        }
    }

    public int GetAlpha()
    {
        return alpha;
    }
    
    public void SetColor(int red, int green, int blue, int alpha)
    {
        if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255 || alpha < 0 || alpha > 255)
        {
            throw new ArgumentException("Invalid color values, must be in range 0 ~ 255.");
        }

        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

    public void SetColor(Color color)
    {
        SetColor(color.red, color.green, color.blue, color.alpha);
    }
    
    public int GetGrayscale()
    {
        return (red + green + blue) / 3;
    }
}