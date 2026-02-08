class ejercicio2
{
    static void Main(String[] args)
    {
        parte1();
        parte2();
    }
    static void parte1()
    {
        int[,] Matrix = {{1,2,3,4,5},{6,7,8,9,10}};
        Console.WriteLine("Parte1:");
        for(int i=0;i<Matrix.GetLength(0);i++)
        {
            for(int j=0;j<Matrix.GetLength(1);j++)
            {
                Console.Write($"{Matrix[i,j]} ");
            }
            Console.WriteLine("");
        }
    }
    static void parte2()
    {
        int[,] Matrix2 = {{1,2,3},{4,5,6},{7,8,9}};
        int sum=0;
        Console.WriteLine("Parte2:");
        for(int i=0; i < Matrix2.GetLength(0); i++)
        {
            for(int j=0;j<Matrix2.GetLength(0); j++)
            {
                sum += Matrix2[i,j];
            }
        }
        Console.WriteLine($"La matriz sumada vale: {sum}");
    }
}
