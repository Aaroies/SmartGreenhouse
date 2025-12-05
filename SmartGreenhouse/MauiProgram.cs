using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;
using SmartGreenhouse.Services;
using SmartGreenhouse.ViewModels;

namespace SmartGreenhouse;

public static class MauiProgram
{
    public static MauiApp? AppInstance;

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        // Services
        builder.Services.AddSingleton<ISensorService, MockSensorService>();

        // ViewModels
        builder.Services.AddTransient<DashboardViewModel>();
        builder.Services.AddTransient<ControlPanelViewModel>();
        builder.Services.AddTransient<HistoryViewModel>();

        AppInstance = builder.Build();
        return AppInstance;
    }
}
