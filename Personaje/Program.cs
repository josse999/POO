namespace Personaje;

class Program
{
    static void Main(String[] args)
    {
        Character persona = new Character("Julian");
        Ghost fantasma = new Ghost("Fantasmin");
        persona.Introduce();
        Console.WriteLine("\n");
        fantasma.Introduce();
    }
}