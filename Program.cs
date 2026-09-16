// Vi skapar ett SavingsAccount eftersom BankAccount är abstrakt.
BankAccount account = new SavingsAccount
{
    Owner = "Alice",
    Balance = 1000
};

Console.WriteLine(account.Describe());