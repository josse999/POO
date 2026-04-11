namespace Inherit_Survivors;

class Program
{
    static void Main(String[] args)
    {
        Citizen juan = new Citizen("Juan",100);
        Citizen felipe = new Citizen("Felipe", 100);
        Soldier edgar = new Soldier("Edgar", 100);
        Engineer jose = new Engineer("Jose", 100, "Lanzapapas automatico");
        int damage=0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("A horde is coming!");
            juan.Defend();
            damage += juan.Getdamage();
            felipe.Defend();
            damage += felipe.Getdamage();
            edgar.Defend();
            damage += edgar.Getdamage();
            edgar.Reload();
            jose.Defend();
            damage += jose.Getdamage();
            jose.ResetTrap();
        }
        Console.WriteLine($"Phew! The horde was defeated. The total damage inflicted is: {damage}");
    }
}
