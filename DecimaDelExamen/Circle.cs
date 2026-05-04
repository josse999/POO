namespace DecimaDelExamen;

public class Circle:Shape
{
    private int Radius;

    public Circle(int newRadius)
    {
        Radius = newRadius;
    }

    public override double CalculateArea()
    {
        return Math.PI*Math.Pow(Radius,2);
    }
}