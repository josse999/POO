namespace Carro;

class Program
{
    static void Main(String[] args)
    {
        Car mazda = new Car("mazda", 0, 3);

        mazda.Accelerate();
        mazda.Accelerate();
        mazda.Accelerate();
        if(mazda.Crash()==true)
            Console.WriteLine("The vehicle crashed");
        if(mazda.Crash()==true)
            Console.WriteLine("The vehicle crashed");
        if(mazda.Crash()==true)
            Console.WriteLine("The vehicle crashed");
        mazda.Opentrunk();
    }
}     
