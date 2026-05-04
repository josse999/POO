namespace DecimaDelExamen;
class Program
{
    static void Main(String[] args)
    {
        Rectangle ei = new Rectangle(4, 5);
        Console.WriteLine(ei.CalculateArea());
        Circle ou = new Circle(4);
        Console.WriteLine(ou.CalculateArea());
    }
}