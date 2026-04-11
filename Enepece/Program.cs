namespace Enepece;

class Program
{
    static void Main(String[] args)
    {
        NPC juan = new NPC("Juan");
        juan.React("Saludar");
        juan.React("Sacudir", 3);
        juan.React("Chocarlas",true);
    }
}