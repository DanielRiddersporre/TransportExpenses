using TransportExpenses.Domain.Enums;

namespace TransportExpenses.Domain.Entities;

public class Expense
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public String Title { get; private set; }
    public DateTime Date { get; private set; }
    public Decimal Amount { get; private set; }
    public ExpenseType Type { get; private set; }

    public Expense(DateTime date, String title, decimal amount, ExpenseType type)
    {
        Date = date;
        Title = title;
        Amount = amount;
        Type = type;
    }
}