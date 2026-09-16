// SavingsAccount ärver Owner, Balance och Describe() från BankAccount.
public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    // Det här är en egen metod som bara finns på savingsaccount.
    public decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}