using Facade.RealWorld;

public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
        Console.WriteLine("Check loans for " + c.Name);
        return true; // Giả định là không có khoản vay xấu
    }
}
