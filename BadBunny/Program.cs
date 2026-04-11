namespace BadBunny;

class Program
{
    static void Main(String[] args)
    {
        string[] album = new string[6]
            { "La Romana", "Tenemos Que Hablar", "Como Antes", "Solo de mi", "Caro", "RNLDT" }; 
        Album X100PRE = new Album("X100PRE",album);
        X100PRE.PlaySong(2);
        X100PRE.PlaySong("Solo de mi");
        X100PRE.PlaySong("RNLDT");
        X100PRE.PlaySong(7);
    }
}