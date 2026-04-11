namespace Estudiante;

public class Professor:Person
{
    private string department;
    private float salary;

    public Professor(string x, string y, int z) : base(x,y,z)
    {
        department = "Engineering";
        salary = 1000;
    }

    public void Teach()
    {
        Console.WriteLine($"Im {Getname()} and i am teaching at {department} ");
    }
}