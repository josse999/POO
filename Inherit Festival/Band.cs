namespace Musica;

public class Band:Artist
{
    private int numOfMembers;

    public Band(
        string newname,
        string newcountry,
        string newgenre,
        int newnumOfMembers):base(newname,newcountry,newgenre)
    {
        numOfMembers = newnumOfMembers;
    }

    public void PlayEncore()
    {
        Random rndm = new Random();
        if(rndm.Next(0, 2)==1)
            Console.WriteLine("Oh, it ended too soon");
        else
            Console.WriteLine($"Wow, the band {name} is playing an extra song!");
    }

    public void GetStageSize()
    {
        if(numOfMembers<5)
            Console.WriteLine($"Hey, we need a Small stage for {name}!");
        else if(numOfMembers<=7)
            Console.WriteLine($"Hey, we need a Medium stage for {name}!");
        else if(numOfMembers>7)
            Console.WriteLine($"Hey, we need a Large stage for {name}!");
    }

    public override void Perform()
    {
        base.Perform();
        Console.WriteLine("this band is the best!");
    }

    public override void Introduce()
    {
        Console.WriteLine($"the band {name}");
        base.Introduce();
    }
}