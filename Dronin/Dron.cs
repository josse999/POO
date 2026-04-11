namespace Dronin;

public class Dron
{
    private int battery;
    private int height;
    private bool droneOn;

    public Dron(int x)
    {
        battery = 100;
        droneOn = true;
        height = x;
    }

    public void Fall()
    {
        droneOn = false;
        height = 0;
        Console.WriteLine("El dron se ha estrellado");
    }

    public void ResetHeight(int x)
    {
        Console.WriteLine($"Cambiar la altura a {x}");
        height = x;
    }

    public void BatterySet(int x)
    {
        if (x > 100)
            Console.WriteLine("La bateria no puede ser mayor a 100");
        else
            battery = x;


    }

}