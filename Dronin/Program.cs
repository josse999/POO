namespace Dronin;

public class Program
{
    static void Main(String[] args)
    {
        Dron dronoide = new Dron(100);
        dronoide.BatterySet(101);
        dronoide.ResetHeight(200);
        dronoide.ResetHeight(400);
        dronoide.ResetHeight(400);
        dronoide.ResetHeight(300);
        dronoide.Fall();
    }
}
