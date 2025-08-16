using System;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;

namespace TransportExpenses.UI.ViewModels
{
    public class AddExpenseViewModel : ReactiveObject
    {
        private string _title = string.Empty;
        private string _amount = string.Empty;

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

        public ReactiveCommand<Unit, Unit> AddExpenseCommand { get; }

        public AddExpenseViewModel()
        {
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

            Console.WriteLine($"Ny utgift skapad: {Title}, {parsedAmount}");
            await Task.CompletedTask;
        }
    }
}