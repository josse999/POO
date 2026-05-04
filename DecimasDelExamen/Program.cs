namespace DecimasDelExamen;

public class Program
{
    static void Main(String[] args)
    {
        StandardShipment estandar = new StandardShipment(10,4,5);
        Console.WriteLine(estandar.CalculateCost(0.2f));
        ExpressShipment express = new ExpressShipment(10, 4);
        Console.WriteLine(express.CalculateCost(0.2f));
    }
}