namespace Musica;

public class Artist
{
    protected string name;
    protected string country; 
    protected string genre;

    public Artist(string newname,string newcountry,string newgenre)
    {
        name = newname;
        country = newcountry;
        genre = newgenre;
    }

     public virtual void Perform()
    {
        Console.WriteLine("Public is going wild. ");
    }

    public virtual void Introduce()
    {
        Console.WriteLine("is going crazy tonight");
    }
}