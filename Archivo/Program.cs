using System;
using System.IO;
namespace Archivo;

public class Program
{
    static void Main(String[] args)
    {
        /*using (StreamReader sr = new StreamReader("C:/Users/josea/OneDrive/Desktop/My_file/Doc.txt"))
        {
            string line;
            while((line = sr.ReadLine()) !=null)
            {
                Console.WriteLine(line);
            }
        }*/
        string path = "C:/Users/josea/OneDrive/Desktop/My_file/Docu.txt";
        File.WriteAllText(path,"El nitrógeno presente en nuestro ADN, el calcio de nuestros dientes, el hierro de nuestra sangre, el carbono en las tartas de manzana ... todos fueron creados en el interior de estrellas que chocaron entre sí. Estamos hechos del material de las estrellas.");

        FileInfo fi = new FileInfo(path);
        Console.WriteLine($"File name: {fi.Name}");
        Console.WriteLine($"File size: {fi.Length}");
        Directory.GetCurrentDirectory();

    }
}