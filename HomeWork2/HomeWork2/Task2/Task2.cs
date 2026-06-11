namespace Task2;

class BankAccount
{
    private int _balance = 0;

    public void Deposit(double amount)
    {
        int convertedAmount = (int)Math.Floor(amount);
        _balance += convertedAmount;
    }

    public void Withdraw(double amount)
    {
        int convertedAmount = (int)Math.Floor(amount);

        if (_balance - convertedAmount < 0)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }

        _balance -= convertedAmount;
    }

    public void ShowBalance()
    {
        Console.WriteLine(_balance);
    }
}