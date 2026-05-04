namespace DecimasDelExamen;

public class StandardShipment : Shipment
{
    private int daysinwarehouse;

    public StandardShipment(float newweight,float newdistance,int newdaysinwarehouse) : base(newweight,newdistance)
    {
        daysinwarehouse = newdaysinwarehouse;
    }

    public float CalculateWarehouseCost()
    {
        return daysinwarehouse*10;
    }

    public override float CalculateCost()
    {
        return weight * distance * 0.05f;
    }

    public float CalculateCost(float taxes)
    {
        return (weight * distance * 0.05f) * (1 + taxes);
    }
}