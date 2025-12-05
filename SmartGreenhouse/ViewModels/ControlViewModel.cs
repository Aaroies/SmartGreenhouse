using SmartGreenhouse.Services;
using System.Windows.Input;

namespace SmartGreenhouse.ViewModels
{
    public class ControlPanelViewModel : BaseViewModel
    {
        private readonly ISensorService _service;
        private bool _fanOn;
        private bool _pumpOn;

        public ControlPanelViewModel(ISensorService service)
        {
            _service = service;
            ToggleFanCommand = new Command(() => Toggle("Fan"));
            TogglePumpCommand = new Command(() => Toggle("Pump"));
            UpdateStates();
        }

        public bool FanOn { get => _fanOn; set => Set(ref _fanOn, value); }
        public bool PumpOn { get => _pumpOn; set => Set(ref _pumpOn, value); }

        public ICommand ToggleFanCommand { get; }
        public ICommand TogglePumpCommand { get; }

        private void Toggle(string name)
        {
            var current = _service.GetActuatorState(name);
            _service.SetActuatorState(name, !current);
            UpdateStates();
        }

        private void UpdateStates()
        {
            FanOn = _service.GetActuatorState("Fan");
            PumpOn = _service.GetActuatorState("Pump");
        }
    }
}
