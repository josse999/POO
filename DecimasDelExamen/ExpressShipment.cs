namespace DecimasDelExamen;

public class ExpressShipment:Shipment
{
    public ExpressShipment(float newweight,float newdistance) : base(newweight,newdistance)
    {

    }

    public void PriorizeShipment()
    {
        Console.WriteLine("Se ha priorizado el envio");
    }

    public override float CalculateCost()
    {
        return (weight * distance * 0.1f + 50);
    }

    public float CalculateCost(float taxes)
    {
        return (weight * distance * 0.1f + 50)*(1 + taxes);
    }
}