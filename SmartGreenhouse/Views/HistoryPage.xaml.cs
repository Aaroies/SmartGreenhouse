using SmartGreenhouse.ViewModels;

namespace SmartGreenhouse.Views;

public partial class HistoryPage : ContentPage
{
    public HistoryPage()
    {
        InitializeComponent();
        BindingContext = MauiProgram.AppInstance?.Services.GetService<HistoryViewModel>() ?? new HistoryViewModel(new SmartGreenhouse.Services.MockSensorService());
    }
}
