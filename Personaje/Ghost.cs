namespace Personaje;

public class Ghost:Character
{
    public Ghost(string newname) : base(newname)
    {
    }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine(", and im a ghost");
    }
}