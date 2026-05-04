namespace ProyectoFinal;

public class Lvl1: Lvl
{
    private bool tr;
    public Lvl1(string newname):base(newname)
    {
        hint[0] = "El codigo tiene que ver con la fecha del fin de una guerra";
        hint[1] = "El codigo tiene que ver con suceso en mayo";
        hint[2] = "El codigo tiene que ver con un dia multiplicado por 8 te da 64";
        comb[0] = 8;
        comb[1] = 5;
        comb[2] = 1945;
        tr = true;
    }

    public override void DoHint()
    {
        base.DoHint();
        if(tr)
            Console.WriteLine($"\ninput1: dia\ninput2: mes\ninput3: año");
        tr = false;
    }
}
