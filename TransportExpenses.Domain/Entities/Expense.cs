using TransportExpenses.Domain.Enums;

namespace TransportExpenses.Domain.Entities;

public class Expense
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime Date { get; private set; }
    public Decimal Amount { get; private set; }
    public ExpenseType Type { get; private set; }

    public Expense(DateTime date, decimal amount, ExpenseType type)
    {
        Date = date;
        Amount = amount;
        Type = type;
    }

    public void UpdateAmount(decimal amount)
    {
        Amount = amount;
    }
}