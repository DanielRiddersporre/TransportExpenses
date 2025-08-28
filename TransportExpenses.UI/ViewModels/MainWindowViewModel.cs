using System.Collections.ObjectModel;

namespace TransportExpenses.UI.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public AddExpenseViewModel AddExpenseViewModel { get; }

    public MainWindowViewModel(AddExpenseViewModel addExpenseViewModel)
    {
        AddExpenseViewModel = addExpenseViewModel;
    }
}
