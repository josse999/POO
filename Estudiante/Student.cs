namespace Estudiante;

public class Student:Person
{
    private string major;
    private int currentsemester;

    public Student(string x, string y, int z) : base(x,y,z)
    {
        major = "Computer Science";
        currentsemester = 5;
    }

    public void AttendClass()
    {
        Console.WriteLine($"I am attending to a class in the {major} major");
    }

    public void DoHomework()
    {
        Console.WriteLine($"I am doing homework");
    }

    public void PrintAge()
    {
        Console.WriteLine($"My current age is {this.age}");
    }
}