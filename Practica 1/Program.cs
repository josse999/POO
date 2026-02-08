class Program
{    static void Main(String[] args)
    {
        int x=1,y=2;
        int [] array = new int[5];
        Console.WriteLine($"La suma es: {x+y}");
        Saludar(x,y);
        Console.WriteLine($"La suma es: {x+y}");
    }
    static void Saludar(int m, int n)
    {
        Console.WriteLine("Hola Mundo");
        m=3;
        n=4;
    }
}