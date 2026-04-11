namespace ConsoleApp2;

public class ElectricStation
{
    private string stationName;
    private int charge;
    private string password;

    public ElectricStation()
    {
        stationName = "Electric Station";
        password = "qwerty123";
    }

    public void SetCharge()
    {
        int y;
        bool x = true;
        x = Passwordcheck();
        if (x != false)
        {
            Console.WriteLine("A continuacion ingrese un valor para la carga: ");
            y = int.Parse(Console.ReadLine());
            if (y > 100)
                Console.WriteLine("La carga no puede ser mayor a 100");
            else
            if(y< 0 )
                Console.WriteLine("Error: La carga no puede ser negativa");
            else
                charge = y;
        }
    }

    public void SetStation()
    {
        bool x = true;
        x = Passwordcheck();
        if (x != false)
        {
            Console.WriteLine("Ingrese el nuevo nombre para la estacion: ");
            stationName = Console.ReadLine();
        }
    }

    private bool Passwordcheck()
    {
        string code;
        Console.WriteLine("Antes de realizar cambios ingrese la contraseña: ");
        code = Console.ReadLine();
        if (code == password)
            return true;
        else
        {
            Console.WriteLine("Error: contraseña incorrecta");
            return false;
        }
    }

    public void PrintName()
    {
        Console.WriteLine(stationName);
    }
}