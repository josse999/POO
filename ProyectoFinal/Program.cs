namespace ProyectoFinal;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("");
        Start();
    }

    static void Start()
    {
        int numOne;
        string name;
        Console.WriteLine("54F3CR4CK3R M33T5 54F3CR4CK3R");
        Console.WriteLine("Nombre de usuario: ");
        name = Console.ReadLine();
        Console.WriteLine(
            $"{name} bienvenido a la caja fuerte mas peligrosa del mundo\nIngrese el nivel donde desea comenzar: ");
        numOne = int.Parse(Console.ReadLine());
        selector(numOne, name);
    }

    static void selector(int x, string y)
    {
        for (int i = x; i <= 3; i++)
        {
            if (i == 1)
            {
                Lvl1 nivel1 = new Lvl1(y);
                Console.WriteLine("\nNivel: 1");
                while (nivel1.ReturnComp()&&nivel1.ReturnStatus())
                    Menu(nivel1);
                if (nivel1.ReturnComp()==false&&nivel1.ReturnStatus()) 
                    Console.WriteLine("Nivel 1 completado!");
                if(nivel1.ReturnStatus()==false)
                    i = 4;
            }

            if (i == 2)
            {
                Lvl2 nivel2 = new Lvl2(y);
                Console.WriteLine("\nNivel: 2");
                while (nivel2.ReturnComp()&&nivel2.ReturnStatus())
                    Menu(nivel2);
                if (nivel2.ReturnComp()==false&&nivel2.ReturnStatus()) 
                    Console.WriteLine("Nivel 2 completado!");
                else 
                    i = 4;
            }

            if (i == 3)
            {
                Lvl3 nivel3 = new Lvl3(y);
                nivel3.Generate();
                Console.WriteLine("\nNivel: 3");
                while (nivel3.ReturnComp()&&nivel3.ReturnStatus())
                    Menu(nivel3);
                if (nivel3.ReturnComp()==false&&nivel3.ReturnStatus())
                    nivel3.Win();
            }                                   
        }
    }
    static void Menu(Lvl1 nivel)
    {
        Console.WriteLine("\nSelector:");
        Console.WriteLine("1. Intentar combinacion");
        Console.WriteLine("2. Usar pista");
        Console.WriteLine("3. Forzar cerradura");
        Console.Write("\nElige una opcion: ");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1": nivel.Atempt(); break;
            case "2": nivel.DoHint(); break;
            case "3":
                Console.Write("Elige un numero del 1 al 3: ");
                int num = int.Parse(Console.ReadLine());
                nivel.Atempt(num);
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }

    static void Menu(Lvl2 nivel)
    {
        Console.WriteLine("\nSelector:");
        Console.WriteLine("1. Intentar combinacion");
        Console.WriteLine("2. Usar pista");
        Console.WriteLine("3. Forzar cerradura");
        Console.Write("\nElige una opcion: ");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1": nivel.Atempt(); break;
            case "2": nivel.DoHint(); break;
            case "3":
                Console.Write("Elige un numero del 1 al 3: ");
                int num = int.Parse(Console.ReadLine());
                nivel.Atempt(num);
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }

    static void Menu(Lvl3 nivel)
    {
        Console.WriteLine("\nSelector:");
        Console.WriteLine("1. Intentar combinacion");
        Console.WriteLine("2. Usar pista");
        Console.WriteLine("3. Forzar cerradura");
        Console.Write("\nElige una opcion: ");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1": nivel.Atempt(); break;
            case "2": nivel.DoHint(); break;
            case "3":
                Console.Write("Elige un numero del 1 al 3: ");
                int num = int.Parse(Console.ReadLine());
                nivel.Atempt(num);
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}

