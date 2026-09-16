// SavingsAccount är en subklass till BankAccount.
public class SavingsAccount : BankAccount
{
    // Här uppfyller vi kravet som den abstrakta klassen ställer, alltså låta describe va speciell för denna klassen.
    public override string Describe()
    {
        return $"Sparkonto: {Owner}, saldo: {Balance:C}";
    }
}