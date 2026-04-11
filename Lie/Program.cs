namespace lie;

class Program
{
    static void Main(String[] args)
    {
        bool lie;
        LieDetector jose = new LieDetector("jose");
        jose.AnalizeAnswer("Yo no robo bro");
        jose.ShowReport();
        lie = jose.IsLier();
        if (lie == true)
            Console.WriteLine("Miente");
        else
            Console.WriteLine("Es verdad");
    }
}