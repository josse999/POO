namespace Game;

public class Character
{
    public String Name;
    public int Health;
    public int MaxHealth;

    public Character(string name,int health,int maxHealth)
    {
        Name = name;
        Health = health;
        MaxHealth = maxHealth;
    }

    public void ShowStats()
    {
        Console.WriteLine($"{Name} has {Health}/{MaxHealth}hp");
    }

    public void RecieveDamage(int amount)
    {
        if (amount > Health)
        {
            Lose();
        }
        else
            Health = Health - amount;
    }

    public void Heal(int amount)
    {
        if (amount > MaxHealth - Health)
        {
            Health = 100;
            Console.WriteLine($"{Name} cannot be healed that much, but the lifepoints are back to 100");
        }
        else
            Health += amount;
    }
    public void Lose()
    {
        Health = 0;
        Console.WriteLine($"{Name} has lost...");
    }
}
