namespace Estudiante;

public class Person
{
    private string name;
    private string gender;
    protected int age;

    public Person(string x, string y, int z)
    {
        name = x;
        gender = y;
        age = z;
    }

    public void salute()
    {
        Console.WriteLine($"Hi, my name is {name}, and I am {age} years old.");
    }

    public string Getname()
    {
        return name;
    }

    public string Getgender()
    {
        return gender;
    }
}

