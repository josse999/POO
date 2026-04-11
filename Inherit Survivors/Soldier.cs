namespace Inherit_Survivors;

public class Soldier:Citizen
{
    private int ammo;

    public Soldier(string newname,int newhealth):base(newname,newhealth)
    {
        ammo = 15;
    }

    public override void Defend()
    {
        Console.WriteLine($"{name} is defending with himself with an axe");
    }

    public override int Getdamage()
    {   if(ammo<5)
            Console.WriteLine($"{name} has no more bullets to battle");
        else
        {
            ammo -= 5;
            Console.WriteLine($"{name} shot his gun, he still has {ammo} more bullets. He made 15 damage");
            return 15;
        }
        return 0;
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }

    public void Reload()
    {
        ammo = 15;
        Console.WriteLine($"{name} has reloaded and is ready to fight!");
    }
}