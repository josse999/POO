namespace Inherit_Survivors;

public class Engineer:Citizen
{
    private string trapName;
    private bool trapstatus;

    public Engineer(string newname, int newhealth,string newtrapName) : base(newname,newhealth)
    {
        trapName = newtrapName;
        trapstatus = true;
    }
    public override void Defend()
    {
        Console.WriteLine($"{name} is defending with himself with an advanced calculus");
    }

    public override int Getdamage()
    {
        if(trapstatus==false)
            Console.WriteLine($"{trapstatus} is not active to be used");
        else
        {
            trapstatus = false;
            Console.WriteLine($"{name} just deployed his {trapName}. he made 45 damage.");
            return 45;
        }
        return 0;
    }

    public void ResetTrap()
    {
        trapstatus = true;
        Console.WriteLine($"{name} has reset his {trapName}.");
    }

    public override void GetStatus()
    {
        base.GetStatus();
    }
}