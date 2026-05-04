using System.Net.Sockets;
using System.Net;
using System.Linq;
namespace ProyectoFinal;

public abstract class Lvl
{
    protected string name;
    protected string[] hint;
    protected int hintNum;
    protected int att;
    protected int code;
    protected int[] comb;
    private bool status;
    private bool completed;

    public Lvl(string newname)
    {
        name = newname;
        hintNum = 1;
        att = 3;
        comb = new int[3];
        hint = new string[3];
        status = true;
        completed = true;
    }


    public virtual void DoHint()
    {
        if (hintNum <= hint.Length)
        {
            Console.WriteLine($"{name} estas Utilizando tu pista numero {hintNum} de {hint.Length}");
            Console.WriteLine(hint[hintNum - 1]);
            hintNum++;
        }
        else
            Console.WriteLine("No quedan pistas por usar");
    }

    public virtual void Atempt()
    {
        if (att > 0)
        {
            Console.WriteLine(
                $"{name} te quedan {att} intentos\n\nIngrese la combinacion que cree que es la verdadera: ");
            for (int i = 1; i <= comb.Length; i++)
            {
                code = int.Parse(Console.ReadLine());
                if (code == comb[i - 1])
                {
                    Console.WriteLine($"La parte {i} de la combinacion esta correcta");
                    if(i>=1&&i<3)
                        Console.WriteLine($"ingrese la clave {i+1}: ");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta, intente denuevo");
                    att--;
                    if (att == 0)
                    {
                        lose();
                    }
                    break;
                }
            }
            if (code == comb[2])
            {
                completed = false;
            }
        }
    }

    public void Atempt(int x)
    {
        Random rndm = new Random();
        int rnd = rndm.Next(1, 4);

        if (x != rnd)
            lose(rnd);
        else
            completed = false;


    }

    public void Win()
    {
        Console.WriteLine($"{name} Ganaste!!\nRevisa tu escritorio para revelar el premio");

        //se investigo para utilizar estos comandos con el fin de que el juego tuviera un final mas hilarante

        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string path = Path.Combine(desktop, "Premio.txt");

        string ip = Dns.GetHostAddresses(Dns.GetHostName())
            .First(a => a.AddressFamily == AddressFamily.InterNetwork)
            .ToString();

        //fin de la investigacion

        File.WriteAllText(path, $"gracias a tu victoria te ganaste un regalito\n{ip}");
    }

    private void lose()
    {
        Console.WriteLine($"{name} tus intentos han sido un fracaso, vuelve a intentarlo");
        status = false;
    }

    private void lose(int x)
    {
        Console.WriteLine($"{name} tus intentos por forzar la cerradura fueron un fracaso, el spot indicado estaba en {x}");
        status = false;
    }

    public bool ReturnStatus()
    {
        return status;
    }
    public bool ReturnComp()
    {
        return completed;
    }
}
