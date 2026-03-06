namespace ConsoleApp2;

public class Program
{
    static void Main(String[] args)
    {
        ElectricStation mexico = new ElectricStation();
        mexico.SetCharge();
        mexico.SetStation();
        mexico.SetStation();
        mexico.PrintName();
        mexico.SetCharge();

    }
}