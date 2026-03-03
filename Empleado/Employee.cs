namespace empleado;

public class Employee
{
    public string[] name;
    public string[] category;
    public int[] id;
    public float[] salary;
    
    public Employee(string[] name, string[] category, int[] id, float[] salary)
    {
        this.name = name;
        this.category = category;
        this.id = id;
        this.salary = salary;
    }

    public void GetSalary()
    {
        float sum=0;
        for (int i=0; i < id.Length; i++)
        {
             sum += salary[i];
        }

        sum = sum / id.Length;
        for (int i = 0; i < id.Length; i++)
        {
            Console.WriteLine($"{name[i]},{category[i]},{id[i]},{salary[i]}");
        }
        Console.WriteLine($"los siguientes empleados ganan menos del sueldo promedio que es ${sum}");
        for (int i = 0; i < id.Length; i++)
        {
            if (salary[i] > sum)
            {
                Console.Write($"{name[i]}");
                if(i<id.Length-1 && salary[i+1]>sum)
                    Console.Write(",");
            }
        }
        Console.WriteLine(".");
    }
}





    
