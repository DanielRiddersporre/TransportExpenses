using TransportExpenses.Domain.Entities;

namespace TransportExpenses.Domain.Interfaces;

public interface ITransportationRepository
{
    Task AddAsync(Transportation transportation);
}