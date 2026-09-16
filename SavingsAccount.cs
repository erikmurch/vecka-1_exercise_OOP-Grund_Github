public class SavingsAccount : BankAccount
{
    public override string Describe()
    {
        return $"Sparkonto: {Owner}, saldo: {Balance:C}";
    }
}