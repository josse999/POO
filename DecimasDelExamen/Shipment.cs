namespace DecimasDelExamen;

public class Shipment
{
    protected float weight;
    protected float distance;

    public Shipment(float newweight, float newdistance)
    {
        weight = newweight;
        distance = newdistance;
    }

    public virtual float CalculateCost()
    {
        return 0;
    }
}