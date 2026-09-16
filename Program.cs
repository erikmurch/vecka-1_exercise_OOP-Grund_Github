// Båda objekten behandlas som BankAccount.
BankAccount[] accounts =
{
    new SavingsAccount { Owner = "Alice", Balance = 1000 },
    new CheckingAccount { Owner = "Bob", Balance = 500 }
};

foreach (BankAccount account in accounts)
{
    // Samma anrop kör olika Describe() beroende på objektets typ.
    Console.WriteLine(account.Describe());
}