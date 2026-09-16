// abstract betyder att vi inte kan skapa ett BankAccount direkt.
public abstract class BankAccount
{
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; }

    // Varje konkret underklass måste skriva sin egen Describe().
    public abstract string Describe();
}