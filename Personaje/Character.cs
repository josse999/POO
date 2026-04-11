namespace Personaje;

public class Character
{
    protected string name;

    public Character(string newname)
    {
        name = newname;
    }

    public virtual void Introduce()
    {
        Console.Write($"Hi bro i am {name}");
    }
}