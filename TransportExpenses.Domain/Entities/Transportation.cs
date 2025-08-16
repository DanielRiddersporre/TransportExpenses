using TransportExpenses.Domain.Enums;

namespace TransportExpenses.Domain.Entities;

public class Transportation(TransportationType type, string name)
{
    public Guid Id { get; private set; } =  Guid.NewGuid();
    public DateTime DateAdded { get; private set; } = DateTime.Now;
    public TransportationType Type { get; private set; } = type;
    public string Name { get; private set; } = name;
    public List<Expense>? Expenses { get; private set; }
}