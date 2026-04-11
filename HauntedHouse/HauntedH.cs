namespace HauntedHouse;

public class HauntedH
{
    private string name;
    private int address;
    private string horrorLevel;

    public HauntedH(string x, int y, string z)
    {
        name = x;
        address = y;
        horrorLevel = z;
    }

    public void Showinfo()
    {
        Console.WriteLine($"Name: {name}\nAddress: {address}\nFear Level: {horrorLevel}");
    }

    public void SpookVisitors()
    {
        Random rndm = new Random();
        int seed = rndm.Next(1, 5);
        if (horrorLevel == "None")
            horrorLevel = "Low";
        else if (horrorLevel == "Low")
            horrorLevel = "Medium";
        else if (horrorLevel == "Medium")
            horrorLevel = "High";
        else if(horrorLevel == "High")
           Console.WriteLine("Your fear level is too high, leaving is highly recommended");

        if (seed == 1)
            Console.WriteLine($"AAAA, You just got stabbed in the liver.\nyour fear level just increased to {horrorLevel}");
        else
        if(seed == 2)
            Console.WriteLine($"Damm, A clown jumped out of a void and stole your wallet.\nyour fear level just increased to {horrorLevel}");
        else
        if(seed == 3)
            Console.WriteLine($"Boo, A drug dealer just laced your cigarettes with fentanyl.\nyour fear level just increased to {horrorLevel}");
        else
        if(seed == 4)
            Console.WriteLine($"Noo, You just tripped and your level of fear increased for being too much guey.\nyour fear level just increased to {horrorLevel}");
    }
}