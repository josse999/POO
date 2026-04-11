namespace Enepece;

public class NPC
{
    private string name;

    public NPC(string x)
    {
        name = x;
    }

    public void React(string x)
    {
        Random rnd = new Random();
        int y = rnd.Next(1, 4);
        if (y == 1)
        {
            Console.WriteLine($"{name} respondio a {x} con una mueca fruncida");
        }
        else if (y == 2)
        {
            Console.WriteLine($"{name} respondio a {x} con una paleta gratis!!");
        }
        else if (y == 3)
        {
            Console.WriteLine($"{name} respondio a {x} con una patada");
        }
    }

    public void React(string x, int y)
    {
        if (y == 1)
        {
            Console.WriteLine($"{name} respondio a {x} con paz y armonia");
        }
        else if (y == 2)
        {
            Console.WriteLine($"{name} respondio a {x} con hostilidad");
        }
        else if (y == 3)
        {
            Console.WriteLine($"{name} respondio a {x} con gritos");
        }
    }

    public void React(string x, bool y)
    {
        if (y == true)
        {
            Console.WriteLine($"{name} respondio a {x} con un abrazo");
        }
        else if (y == false)
        {
            Console.WriteLine($"{name} respondio a {x} con seriedad");
        }
    }
}