public interface ILateFeeStrategy
{
    decimal Calculate(int days);
}

public class StudentFeeStrategy : ILateFeeStrategy
{
    public decimal Calculate(int days) => days * 2.00m;
}

public class FacultyFeeStrategy : ILateFeeStrategy
{
    public decimal Calculate(int days) => days * 0.50m;
}

public class Member
{
    private readonly ILateFeeStrategy _strategy;
    public Member(ILateFeeStrategy strategy)
    {
        _strategy = strategy;
    }
    public decimal GetFee(int days) => _strategy.Calculate(days);

}