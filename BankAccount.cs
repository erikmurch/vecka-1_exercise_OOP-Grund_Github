public class BankAccount
{
    //Attributer
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; } 


//metoder
//Virtual gör att subklasser kan skriva över metoden/skriva egna versioner av metoden
    public virtual string Describe()
    {
        return $"Owner: {Owner}, Balance: {Balance:C}";
    }
}