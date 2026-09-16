SavingsAccount account = new SavingsAccount();

account.Owner = "Alice";       // Ärvs från BankAccount.
account.Balance = 1000;        // Ärvs från BankAccount.
account.InterestRate = 0.05m; // 5 procent ränta.

Console.WriteLine(account.Describe()); // Ärvs också.
Console.WriteLine($"Ränta: {account.CalculateInterest():C}");