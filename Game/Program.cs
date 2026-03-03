namespace Game;

public class Program
{
    static void Main(String[] args)
    {
        string name = "fernan";
        int health=100, maxHealth=100;
        
        Character fernan = new Character(name,health,maxHealth);
        Console.WriteLine($"{name} with {maxHealth}hp has been created");
        fernan.RecieveDamage(30);
        fernan.ShowStats();
        fernan.Heal(20);
        fernan.ShowStats();
        fernan.Heal(200);
        fernan.RecieveDamage(300);
    }
}