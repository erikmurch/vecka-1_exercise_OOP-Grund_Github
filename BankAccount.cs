public class BankAccount
{
    //Attributer
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; } 


//metoder
    public string Describe()
    {
        return $"Owner: {Owner}, Balance: {Balance:C}";
    }
}