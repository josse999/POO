using System.CodeDom.Compiler;

namespace ProyectoFinal;

public class Lvl3:Lvl
{
    public Lvl3(string newname) : base(newname)
    {
        hint[0] = "El primer codigo esta en alguna parte del salon de POO";
        hint[1] = "Este codigo esta simple vista en tus archivos";
        hint[2] = "Apresurate para encontrar este codigo porue su ubicacion es temporal";
        comb[0] = 202;
        comb[1] = 8273;
        comb[2] = 3554;
    }

    public void Generate()
    {
        string path1, path2;

        //Mismo principio por que la ruta al escritorio siempre cambia

        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path1 = Path.Combine(desktop, "†̭̱̖͔̖̰̦͔͖͍͚̯̪̙̆̿́̄̍̇̈̾̈́̋͆̋̓̓.txt");
        File.WriteAllText(path1,"8273");
        path2 = @"C:\Windows\Temp\X͇̳͍͓͕̯͎͍̋̔̆̏̂̋̉͑̃̀̋̊͑̀.txt";
        File.WriteAllText(path2,"3554");
    }
}