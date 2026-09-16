public class BankAccount
{
    public string Owner { get; set; } = "";

    // Privat: Program.cs kan inte ändra saldot direkt.
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        // Ta bara ut pengar om beloppet är giltigt och pengarna räcker.
        if (amount > 0 && amount <= _balance)
            _balance -= amount;
    }

    public string Describe()
    {
        return $"Owner: {Owner}, Balance: {_balance:C}";
    }
}