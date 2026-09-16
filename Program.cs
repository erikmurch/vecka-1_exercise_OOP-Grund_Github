BankAccount BankAccount1 = new BankAccount();
BankAccount1.Owner = "Alice";

// Saldot ändras via metoder eftersom _balance är privat.
BankAccount1.Deposit(1000);
BankAccount1.Withdraw(200);

Console.WriteLine(BankAccount1.Describe());