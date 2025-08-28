using TransportExpenses.Domain.Entities;
using TransportExpenses.Domain.Interfaces;
using TransportExpenses.Infrastructure.Persistence.Context;

namespace TransportExpenses.Infrastructure.Persistence;

public class ExpenseRepository : IExpenseRepository
{
    private readonly TransportExpensesDbContext _context;
    public ExpenseRepository(TransportExpensesDbContext dbContext)
    {
        _context = dbContext;
    }
    public async Task AddAsync(Expense expense)
    {
        _context.Add(expense);
        Console.WriteLine($"{expense.Title} added!");
        await _context.SaveChangesAsync();
    }
}