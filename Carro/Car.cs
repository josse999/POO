namespace Carro;

public class Car:Vehicle
{
    private int doorsnum;

    public Car(string newbrand, int newspeed,int newdoorsnum):base(newbrand, newspeed)
    {
        doorsnum = newdoorsnum;
    }

    public void Opentrunk()
    {
        if (doorsnum % 2 != 0)
            Console.WriteLine("The trunk has been opened");
        else
            Console.WriteLine("The vehicle has no trunk");
    }
}