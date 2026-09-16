public class CheckingAccount : BankAccount
{
    public override string Describe()
    {
        return $"Lönekonto: {Owner}, saldo: {Balance:C}";
    }
}