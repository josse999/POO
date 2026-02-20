
public class Book
{
    private string title;
    private string author;
    private int pages;
    private bool open;

    public Book()
    {
        title = "Hola";
        author = "Jose";
        pages = 300;
        open = false;
    }

    public void Showinfo()
    {
        Console.WriteLine($"El titulo de este libro es {title}, contiene {pages} paginas y esta hecho por {author}");
    }
    public void Open()
    {
        open = true;
    }
    public void Close()
    {
        open = false;
    }
}