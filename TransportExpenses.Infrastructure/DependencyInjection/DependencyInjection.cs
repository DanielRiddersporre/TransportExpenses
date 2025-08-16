using Microsoft.Extensions.DependencyInjection;
using TransportExpenses.Domain.Interfaces;
using TransportExpenses.Infrastructure.Persistence;

namespace TransportExpenses.Infrastructure.DependencyInjection;

public class DependencyInjection
{
     public static IServiceCollection AddApplicationServices(IServiceCollection services)
     {
          services.AddScoped<IExpenseRepository, ExpenseRepository>();
          services.AddScoped<ITransportationRepository, TransportationRepository>();
          return services;
     }
}