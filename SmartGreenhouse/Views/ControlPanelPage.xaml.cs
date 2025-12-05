using SmartGreenhouse.ViewModels;

namespace SmartGreenhouse.Views;

public partial class ControlPanelPage : ContentPage
{
    public ControlPanelPage()
    {
        InitializeComponent();
        BindingContext = MauiProgram.AppInstance?.Services.GetService<ControlPanelViewModel>() ?? new ControlPanelViewModel(new SmartGreenhouse.Services.MockSensorService());
    }
}
