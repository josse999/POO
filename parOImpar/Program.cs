class parOImpar
{
    static void Main(string[] args)
    {   
        int numOne;
        Console.WriteLine("Bienvenido a el programa que determina si un numero es par o impar\n Ingrese el numero: ");
        numOne = int.Parse(Console.ReadLine());
        mod2(numOne);
    }

    static void mod2(int x)
    {
        if (x % 2 == 0)
            Console.WriteLine($"El numero ingresado '{x}' es par");   
        else
            Console.WriteLine($"El numero ingresado '{x}' es impar");
    }
}
