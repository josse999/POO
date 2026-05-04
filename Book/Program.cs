namespace Book;

class Program
{
    static void Main(String[] args)
    {
        Libro librin = new Libro();
        librin.AddParagraph("Este es el primer parrafo del libro");
        librin.AddParagraph("Este es el parrafo numero 2");
        librin.AddParagraph("Este es el parrafo 3 del texo");
        librin.SaveToFile();
        librin.PrintFileContent();
        librin.SaveToFile();
        librin.PrintFileContent();
    }
}