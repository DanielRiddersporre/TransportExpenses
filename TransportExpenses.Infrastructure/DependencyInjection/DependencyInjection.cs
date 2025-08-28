using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TransportExpenses.Application.UseCases;
using TransportExpenses.Domain.Interfaces;
using TransportExpenses.Infrastructure.Persistence;
using TransportExpenses.Infrastructure.Persistence.Context;

namespace TransportExpenses.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
     public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
     {
          services.AddDbContext<TransportExpensesDbContext>(options =>
               options.UseSqlite(connectionString));
          
          services.AddScoped<IExpenseRepository, ExpenseRepository>();
          services.AddScoped<ITransportationRepository, TransportationRepository>();

          services.AddScoped<AddExpenseUseCase>();
          
          return services;
     }
}