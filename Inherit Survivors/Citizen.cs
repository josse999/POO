namespace Inherit_Survivors;

public class Citizen
{
    protected string name;
    protected int health;

    public Citizen(string newname,int newhealth)
    {
        name = newname;
        health = newhealth;
    }

    public virtual void Defend()
    {
        Console.WriteLine($"{name} is defending with his own hands.");
    }

    public virtual void GetStatus()
    {
        Console.WriteLine($"{name} is fine and breathing");
    }

    public virtual int Getdamage()
    {
        Console.WriteLine($"{name} hit a zombie. He made 5 damage");
        return 5;
    }
    public void Hide()
    {
        Console.WriteLine($"{name} is currently hiding");
    }
}