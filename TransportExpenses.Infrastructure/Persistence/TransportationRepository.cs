using TransportExpenses.Domain.Entities;
using TransportExpenses.Domain.Interfaces;

namespace TransportExpenses.Infrastructure.Persistence;

public class TransportationRepository  : ITransportationRepository
{
    public Task AddAsync(Transportation transportation)
    {
        throw new NotImplementedException();
    }
}