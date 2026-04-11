namespace Pizzonga;

public class Pizza
{
    private string[] ing;

    public Pizza(string[] x)
    {
        ing = x;
    }

    public void OrderPizza()
    {
        Console.WriteLine("A plain pizza has been delivered!");
    }

    public void OrderPizza(string[] x)
    {
        bool y = false, conf = true;
        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < ing.Length; j++)
                if (x[i] == ing[j])
                    y = true;
            if (y == false)
            {
                Console.WriteLine($"Sorry, the ingredient {x[i]} is not valid");
                conf = false;
            }
        }
        if (conf == true)
        {
            Console.WriteLine("The pizza has been delivered!");
        }
    }

    public void OrderPizza(bool x)
        {
            if (x == true)
                Console.WriteLine("A plain pizza with extra cheese has been delivered!");
            else OrderPizza();
        }

    }