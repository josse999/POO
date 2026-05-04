namespace ProyectoFinal;

public class Lvl2: Lvl
{
    public Lvl2(string newname):base(newname)
    {
        hint[0] = "El codigo es una sucesion";
        hint[1] = "El codigo crece";
        hint[2] = "El codigo no es lo que te esperas";
        comb[0] = 1;
        comb[1] = 2;
        comb[2] = 3;
    }
}