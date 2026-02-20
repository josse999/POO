class Program
{
    static void Main(String[] agrs)
    {
        Employee employee = new Employee();
        Console.WriteLine($"El salario de {employee.name} con id {employee.id} y rango de {employee.category} es de {employee.salary}");
    }
}