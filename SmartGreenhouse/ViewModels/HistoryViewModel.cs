using SmartGreenhouse.Models;
using SmartGreenhouse.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace SmartGreenhouse.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        public ObservableCollection<SensorReading> Readings { get; } = new();

        public HistoryViewModel(ISensorService service)
        {
            lock (service.History)
            {
                foreach (var r in service.History.TakeLast(50)) Readings.Add(r);
            }

            service.ReadingUpdated += (_, r) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Readings.Add(r);
                    if (Readings.Count > 200) Readings.RemoveAt(0);
                });
            };
        }
    }
}
