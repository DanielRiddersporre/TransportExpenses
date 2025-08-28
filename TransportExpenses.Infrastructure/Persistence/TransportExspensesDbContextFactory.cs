using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TransportExpenses.Infrastructure.Persistence.Context;

namespace TransportExpenses.Infrastructure.Persistence
{
    public class TransportExpensesDbContextFactory : IDesignTimeDbContextFactory<TransportExpensesDbContext>
    {
        public TransportExpensesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TransportExpensesDbContext>();
            optionsBuilder.UseSqlite("Data Source=Data/expenses.db");
            return new TransportExpensesDbContext(optionsBuilder.Options);
        }
    }
}