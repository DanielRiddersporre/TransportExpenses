using System;
using System.Collections.Generic;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;
using TransportExpenses.Application.UseCases;
using TransportExpenses.Domain.Entities;
using TransportExpenses.Domain.Enums;

namespace TransportExpenses.UI.ViewModels
{
    public class AddExpenseViewModel : ReactiveObject
    {
        private string _title = string.Empty;
        private string _amount = string.Empty;
        private string _description = string.Empty;
        private ExpenseType _selectedExpenseType;
        
        public IEnumerable<ExpenseType> ExpenseTypes { get; } = Enum.GetValues<ExpenseType>();

        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        public string Amount
        {
            get => _amount;
            set => this.RaiseAndSetIfChanged(ref _amount, value);
        }

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public ExpenseType SelectedExpenseType
        {
            get => _selectedExpenseType;
            set => this.RaiseAndSetIfChanged(ref _selectedExpenseType, value);
        }

        public ReactiveCommand<Unit, Unit> AddExpenseCommand { get; }
        private readonly AddExpenseUseCase _addExpenseUseCase;

        public AddExpenseViewModel(AddExpenseUseCase addExpenseUseCase)
        {
            _addExpenseUseCase = addExpenseUseCase;
            AddExpenseCommand = ReactiveCommand.CreateFromTask(AddExpense);
        }

        private async Task AddExpense()
        {
            if (string.IsNullOrWhiteSpace(Title) || string.IsNullOrWhiteSpace(Amount))
            {
                Console.WriteLine("Alla fält måste vara ifyllda!");
                return;
            }

            if (!decimal.TryParse(Amount, out var parsedAmount))
            {
                Console.WriteLine("Beloppet måste vara ett nummer!");
                return;
            }
            
            var expense = new Expense(DateTime.Now, _title, parsedAmount, _selectedExpenseType);

            await _addExpenseUseCase.ExecuteAsync(expense);
        }
    }
}