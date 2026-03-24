using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MyApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<string> Periods { get; } = new()
    {
        "Daily",
        "Weekly",
        "Monthly",
        "Yearly"
    };

    [ObservableProperty]
    private string? selectedPeriod;

    public MainWindowViewModel()
    {
        SelectedPeriod = Periods[0];
    }
}
