using TransportExpenses.Domain.Entities;

namespace TransportExpenses.Domain.Interfaces;

public interface IExpenseRepository
{
    Task AddAsync(Expense expense);
}