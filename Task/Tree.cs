namespace Task;

public class Tree
{
    public int size;
    public string foliage;
    public int s;

    public Tree()
    {
        size = 100;
        s = 3;
        if (s == 3)
            foliage = "too much";
        else if (s == 2)
            foliage = "Not much";
        else if (s == 1)
            foliage = "None";
    }
//Check size
    public void Cs()
    {
        if (s == 3)
            foliage = "too much";
        else if (s == 2)
            foliage = "Not much";
        else if (s == 1)
            foliage = "None";
    }

    public void Bloom()
    {
        size += 10;
        Cs();
        Console.WriteLine($"The new size is {size}");
    }

    public void Dry()
    {
        s--;
        Cs();
        Console.WriteLine($"The new foliage is {foliage}");
    }
}