using empleado;

public class Program
{
    static void Main(String[] args)
    {
        string[] name = new string[3];
        string[] category = new string[3];
        int[] id = new int[3];
        float[] salary = new float[3];

        for (int i = 0; i < id.Length; i++)
        {
            id[i] = i + 1;
            Console.WriteLine(
                $"Bienvenido, su id es oficialmente el numero {i + 1}.\nA continuacion ingrese su nombre: ");
            name[i] = Console.ReadLine();
            Console.WriteLine(
                "En que categoria se encuentra usted actualmente?\n1-Finanzas\n2-Negocios\n3-Ingenierias\n4-Medicina");
            int cat = int.Parse(Console.ReadLine());
            switch (cat)
            {
                case 1:
                    category[i] = "finanzas";
                    break;
                case 2:
                    category[i] = "Negocios";
                    break;
                case 3:
                    category[i] = "Ingrenierias";
                    break;
                case 4:
                    category[i] = "Medicina";
                    break;
                default: Console.WriteLine("Opcion no valida");
                    break;
            }

            Console.WriteLine("Ingrese su sueldo: ");
            salary[i] = int.Parse(Console.ReadLine());
        }

        Employee joven = new Employee(name,category,id,salary);
        joven.GetSalary();
    }
}