namespace Pizzonga;

class program
{
    static void Main(String[] args)
    {
        string[] ing = new string[] {"Peperoni", "champiñones", "sardina", "alcachofa", "carnes frias"};
        string[] i = new string[] {"Peperoni", "champiñones"};
        string[] j = new string[] {"Platano", "champiñones"};
        Pizza pequeñocesar = new Pizza(ing);
        pequeñocesar.OrderPizza();
        pequeñocesar.OrderPizza(true);
        pequeñocesar.OrderPizza(false);
        pequeñocesar.OrderPizza(i);
        pequeñocesar.OrderPizza(j);
    }
}