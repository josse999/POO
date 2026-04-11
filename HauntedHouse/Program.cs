namespace HauntedHouse;

class Program
{
    static void Main(String[] args)
    {
        string name = "jose", horrorLevel = "None";
        int address = 0;
        HauntedH jose = new HauntedH(name,address,horrorLevel);
        jose.Showinfo();
        jose.SpookVisitors();
        jose.Showinfo();
        jose.SpookVisitors();
        jose.SpookVisitors();
        jose.SpookVisitors();
        jose.Showinfo();
    }
}