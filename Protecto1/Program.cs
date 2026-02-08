int numOne,numTwo;

Console.WriteLine("Bienvenido a el generador de tablas de multiblicar");
Console.WriteLine("Ingrese el numero del que quiere generar la tabla: ");

numOne = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    numTwo=i*numOne;
    Console.Write(numTwo + " ");
}
