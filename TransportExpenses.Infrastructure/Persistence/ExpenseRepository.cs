using TransportExpenses.Domain.Entities;
using TransportExpenses.Domain.Interfaces;

namespace TransportExpenses.Infrastructure.Persistence;

public class ExpenseRepository : IExpenseRepository
{
    public Task AddAsync(Expense expense)
    {
        throw new NotImplementedException();
    }
}