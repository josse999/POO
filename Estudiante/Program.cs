namespace Estudiante;

class Program
{
    static void Main(String[] args)
    {
        Student Julio = new Student("Julio", "Male", 30);
        Julio.PrintAge();
        Professor Julio2 = new Professor("Andrea", "Female", 21);
        Julio2.Teach();
    }
}