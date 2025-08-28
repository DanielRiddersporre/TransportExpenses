using TransportExpenses.Domain.Entities;
using TransportExpenses.Domain.Interfaces;

namespace TransportExpenses.Application.UseCases;

public class AddExpenseUseCase
{
    private readonly IExpenseRepository _expenseRepository;

    public AddExpenseUseCase(IExpenseRepository expenseRepository)
    {
        _expenseRepository = expenseRepository;
    }

    public async Task ExecuteAsync(Expense expense)
    {
        await _expenseRepository.AddAsync(expense);
    }
}