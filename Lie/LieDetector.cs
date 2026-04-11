namespace lie;

public class LieDetector
{
    private string suspectName;
    private string question;
    private int suspicionLevel;
    private int minSuspicion;
    private int maxSuspicion;

    public LieDetector(string x)
    {
        suspectName = x;
        suspicionLevel = 1;
        minSuspicion = 1;
        maxSuspicion = 6;
    }

    public void AnalizeAnswer(string x)
    {
        string suspicion = "Nada";
        question = x;
        Random rndm = new Random();
        suspicionLevel = rndm.Next(minSuspicion, maxSuspicion);
        if (suspicionLevel == 1)
            suspicion = "Bajo";
        else if (suspicionLevel == 2)
            suspicion = "Medio";
        else if (suspicionLevel == 3)
            suspicion = "Considerable";
        else if (suspicionLevel == 4)
            suspicion = "Alto";
        else if (suspicionLevel == 5)
            suspicion = "Mentiroso seguro";
            
                
            
        
        Console.WriteLine($"El detector de mentiras esta activo!\nLa frase a analizar es: {question}\nAnalizando...\nDespues de analizar su nivel de sospecha de determino como {suspicion}");
    }

    public void ShowReport()
    {
        Console.WriteLine($"La ultima pregunta analizada del sujeto {suspectName} fue: {question}\nel nivel de sospecha es de {suspicionLevel}");
    }

    public bool IsLier()
    {
        bool x = false;
        if (suspicionLevel > 3)
            x = true;
        return x;
    }
}