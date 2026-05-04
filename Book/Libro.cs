namespace Book;

public class Libro
{
    private string title;
    private string author;
    private string path;
    private string[] paragraphs;
    private int nextParagrahp;

    public Libro()
    {
        paragraphs = new string[3];
        nextParagrahp = 0;
    }

    public void AddParagraph(String x)
    {
        if (nextParagrahp < 3)
        {
            if (nextParagrahp == 0)
                paragraphs[0] = x;
            else if (nextParagrahp == 1)
                paragraphs[1] = x;
            else
                paragraphs[2] = x;
            nextParagrahp++;
        }
        else
            Console.WriteLine("Error: el arreglo esta lleno");
    }

    public void SaveToFile()
    {
        string path = @"C:\Users\josea\OneDrive\Desktop\My_file\Book.txt";
        File.WriteAllLines(path,paragraphs);
    }

    public void PrintFileContent()
    {
        string path = @"C:\Users\josea\OneDrive\Desktop\My_file\Book.txt";
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);

    }
}