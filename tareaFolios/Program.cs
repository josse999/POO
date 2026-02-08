class tareaFolios
{
    static void Main(String[] args)
    {
        int[] folios = {10,14,101,105,801,1607,2034,5607};
        int scanned;
        Console.WriteLine("Bienvenido al programa verificador de folios de la empresa\n-A continuacion ingrese el folio a verificar: ");
        scanned = int.Parse(Console.ReadLine());
        
        check(folios,scanned);

    }
    static void check(int[] x,int folio)
    {   bool argument = false;
        for(int i = 0; i < x.Length;i++)
        {
            if(x[i]==folio){
                Console.WriteLine($"El folio ingresado es valido y corresponde a la posicion {i+1} de la lista");
                argument = true;
            }
        }
        if(argument==false)
        Console.WriteLine($"El folio ingresado es invalido, intentelo denuevo.");
    }
}