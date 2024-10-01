using Facade.RealWorld;

public class Credit
{
    public bool HasGoodCredit(Customer c)
    {
        Console.WriteLine("Check credit for " + c.Name);
        return true; // Giả định là có điểm tín dụng tốt
    }
}
