namespace ProyectoFinal;

public class Lvl1: Lvl
{
    public Lvl1(string newname):base(newname)
    {
        hint[0] = "El codigo tiene que ver con la fecha del fin de una guerra 1dia/2mes/3año";
        hint[1] = "El codigo tiene que ver con suceso en mayo";
        hint[2] = "El codigo tiene que ver con un dia multiplicado por 8 te da 64";
        comb[0] = 8;
        comb[1] = 5;
        comb[2] = 1945;
    }
}
