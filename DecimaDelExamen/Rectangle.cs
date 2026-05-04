namespace DecimaDelExamen;

public class Rectangle:Shape
{
    private int Base;
    private int Height;

    public Rectangle(int newBase, int newHeight):base()
    {
        Base = newBase;
        Height = newHeight;

    }

    public override double CalculateArea()
    {
        return Base * Height;
    }
}
