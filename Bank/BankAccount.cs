namespace Bank;

public class BankAccount
{
    public string holder;
    public int balance;

    public BankAccount(string hol,int bal)
    {
        holder = hol;
        balance = bal;
    }

    public void Showbalance()
    {
        Console.WriteLine($"El saldo de la cuenta del usuario {holder} es de ${balance}");
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Se depositaron ${amount}");
        }
        else
            Console.WriteLine("La cantidad ingresada no es valida");
    }

    public void Withdraw(int amount)
    {
        if (amount <= balance)
            balance -= amount;
        else 
            Console.WriteLine($"No es posible retirar ${amount} por que es una cantidad mayor al sueldo que es de ${balance}");
    }
}