namespace Bank;

class Program
{
    static void Main(String[] args)
    {
        BankAccount jose = new BankAccount();

        jose.holder = "José";
        jose.balance = 1000;
        jose.Showbalance();
        jose.Deposit(500);
        jose.Withdraw(2000);
        jose.Withdraw(500);
        jose.Showbalance();
    }
}