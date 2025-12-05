using SmartGreenhouse.Models;
using SmartGreenhouse.Services;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace SmartGreenhouse.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private readonly ISensorService _service;
        private SensorReading? _current;

        public DashboardViewModel(ISensorService service)
        {
            _service = service;
            _service.ReadingUpdated += (_, r) => MainThread.BeginInvokeOnMainThread(() => CurrentReading = r);

            StartCommand = new Command(() => _service.Start());
            StopCommand = new Command(() => _service.Stop());
            ToControlCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushAsync(new Views.ControlPanelPage()));
            ToHistoryCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushAsync(new Views.HistoryPage()));
        }

        public SensorReading? CurrentReading { get => _current; set => Set(ref _current!, value!); }
        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand ToControlCommand { get; }
        public ICommand ToHistoryCommand { get; }
    }
}
