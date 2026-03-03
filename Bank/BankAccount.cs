namespace Bank;

public class BankAccount
{
    public string holder;
    public int balance;

    public BankAccount()
    {
        holder = "None";
        balance = 0;
    }

    public void Showbalance()
    {
        Console.WriteLine($"El saldo de la cuenta del usuario {holder} es de {balance}");
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("La cantidad ingresada no es valida");
    }

    public void Withdraw(int amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
        else 
            Console.WriteLine("La cantidad ingresada no es valida");
    }
}