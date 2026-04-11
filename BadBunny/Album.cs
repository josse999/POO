namespace BadBunny;

public class Album
{
    private string name;
    private string[] songNames;

    public Album(string x,string[] y)
    {
        name = x;
        songNames = y;
    }

    public void PlaySong(int x)
    {
        if(x<=songNames.Length)
            Console.WriteLine($"Usted esta reproduciendo: {x}.{songNames[x]}");
        else
            throw new IndexOutOfRangeException("El numero de cancion se sale del index del album");
    }

    public void PlaySong(string x)
    {
        for (int i = 0; i < songNames.Length; i++)
        {
            if(x == songNames[i])
                Console.WriteLine($"Usted esta reproduciendo: {i}.{songNames[i]}");
        }
    }


}