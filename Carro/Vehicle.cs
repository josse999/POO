namespace Carro;

public class Vehicle
{
    protected string brand;
    protected int speed;

    public Vehicle(string newbrand, int newspeed)
    {
        brand = newbrand;
        speed = newspeed;
    }

    public void Accelerate()
    {
        speed += 40;
        Console.WriteLine($"New speed: {speed}");
    }

    public void Break()
    {
        speed = 0;
    }

    public bool Crash()
    {
        bool rndm = false;
        Random random = new Random();
        if (speed > 100)
        {
            if (random.Next(0, 2) == 1)
                rndm = true;
            else
                rndm = false;
        }
        return rndm;
    }
}