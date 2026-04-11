namespace Musica;

public class Dj:Artist
{
    private string software;
    public Dj(
        string newname,
        string newcountry,
        string newgenre,
        string newsoftware):base(newname,newcountry,newgenre)
    {
        software = newsoftware;
    }

    public void MixTrack()
    {
        Random rndm = new Random();
        Console.WriteLine($"This track length is {rndm.Next(2,6)} minutes");
    }

    public int GetEnergyLevel()
    {
        Random rndm = new Random();
        return rndm.Next(1,4);
    }

    public override void Introduce()
    {
        Console.WriteLine($"The dj {name} ");
        base.Introduce();
    }

    public override void Perform()
    {
        base.Perform();
        Console.WriteLine("This dj is going crazy tonight");
    }
}   