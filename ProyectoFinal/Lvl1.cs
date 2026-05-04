namespace ProyectoFinal;

public class Lvl1: Lvl
{
    public Lvl1(string newname):base(newname)
    {
        hint[0] = "El codigo tiene que ver con la fecha de un suceso importante";
        hint[1] = "El codigo tiene que ver con una guerra";
        hint[2] = "El codigo tiene que ver con alemania";
        comb[0] = 8;
        comb[1] = 5;
        comb[2] = 1945;
    }
}
