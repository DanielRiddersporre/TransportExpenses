using Microsoft.EntityFrameworkCore;
using TransportExpenses.Domain.Entities;

namespace TransportExpenses.Infrastructure.Persistence.Context;

public class TransportExpensesDbContext(DbContextOptions<TransportExpensesDbContext> options) 
    : DbContext(options)
{
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Transportation> Transportations { get; set; }
}