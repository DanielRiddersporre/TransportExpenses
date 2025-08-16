using Avalonia.Controls;
using TransportExpenses.UI.ViewModels;

namespace TransportExpenses.UI.Views;

public partial class AddExpenseView : UserControl
{
    public AddExpenseView()
    {
        InitializeComponent();
        DataContext = new AddExpenseViewModel();
    }
}