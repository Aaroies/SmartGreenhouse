using SmartGreenhouse.ViewModels;

namespace SmartGreenhouse.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        // resolve DashboardViewModel via DI
        BindingContext = MauiProgram.AppInstance?.Services.GetService<DashboardViewModel>() ?? new DashboardViewModel(AppInstanceServiceFallback());
    }

    // fallback in case DI not available (very unlikely)
    private static SmartGreenhouse.Services.ISensorService AppInstanceServiceFallback()
    {
        return new SmartGreenhouse.Services.MockSensorService();
    }
}
