using System.Data;
class Tarea2
{
    static void Main(String[] args)
    {
        int n=3,m;
        Console.WriteLine("Bienvenido al nuevo operador de numeros en C# Completamente funcional\n-Ingrese la cantidad de numeros a operar: ");
        m = int.Parse(Console.ReadLine());
        int[] arrOne = new int[m];
        double[,] mtrxOne = new double[n,m];
        Fill(arrOne);
        Opp(arrOne,mtrxOne);
        PrintMtrx(mtrxOne);
        
        
    }
    static void Fill(int[] x)
    {
        for (int i=0;i<x.Length;i++)
        {
            Console.WriteLine($"Ingrese el valor numero {i+1}:");
            x[i] = int.Parse(Console.ReadLine());
        }
    }
    static void Opp(int[] x,double[,] y)
    {
        for(int i=0;i<y.GetLength(0);i++)
            for(int j=0;j<y.GetLength(1);j++)
            {
                if(i==0)
                    y[i,j] = x[j];
                else
                if(i==1)
                    y[i,j] = Math.Pow(x[j],2);
                else
                    y[i,j] = Math.Pow(x[j],3);
            }
    }
    static void PrintMtrx(double[,] y)
    {
        for(int i=0;i<y.GetLength(1);i++)
        {
            Console.Write($"{y[0,i]}");
            if (i<y.GetLength(1)-1)
                Console.Write(", ");
        }
        Console.WriteLine("");
        for(int i=0;i<y.GetLength(1);i++)
        {
            Console.Write($"{y[1,i]}");
            if (i<y.GetLength(1)-1)
                Console.Write(", ");
            
        }
        Console.WriteLine("");
        for(int i=0;i<y.GetLength(1);i++)
        {
            Console.Write($"{y[2,i]}");
            if (i<y.GetLength(1)-1)
                Console.Write(", ");
        }  
    }
}