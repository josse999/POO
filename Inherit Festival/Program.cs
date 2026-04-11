namespace Musica;

class Program
{
    static void Main(String[] args)
    {
        Band caifanes = new Band("Caifanes","Mexico","Rock",4);
        caifanes.GetStageSize();
        caifanes.Perform();
        caifanes.PlayEncore();
        Dj davidGuetta = new Dj("David Guetta","France","Techno","Fl studio");
        davidGuetta.MixTrack();
        Energy(davidGuetta.GetEnergyLevel());
    }

    static void Energy(int x)
    {
        if (x==1)
            Console.WriteLine("Energy level is low");
        else if(x==2)
            Console.WriteLine("Energy level is medium");
        else if(x==3)
            Console.WriteLine("Energy level is High");


    }
}