using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SmartGreenhouse.Models;

namespace SmartGreenhouse.Services
{
    public class MockSensorService : ISensorService
    {
        private Timer? _timer;
        private readonly List<SensorReading> _history = new();
        private readonly Random _rnd = new();
        private readonly Dictionary<string, bool> _actuators = new()
        {
            { "Fan", false },
            { "Pump", false }
        };

        public event EventHandler<SensorReading>? ReadingUpdated;
        public IReadOnlyList<SensorReading> History => _history.AsReadOnly();

        public void Start()
        {
            if (_timer is not null) return;
            _timer = new Timer(_ => GenerateReading(), null, 0, 1500);
        }

        public void Stop()
        {
            _timer?.Dispose();
            _timer = null;
        }

        private void GenerateReading()
        {
            var temp = 18 + _rnd.NextDouble() * 14;
            var hum = 35 + _rnd.NextDouble() * 50;
            var soil = 25 + _rnd.NextDouble() * 60;

            var r = new SensorReading
            {
                Timestamp = DateTime.Now,
                TemperatureC = Math.Round(temp, 1),
                Humidity = Math.Round(hum, 1),
                SoilMoisture = Math.Round(soil, 1)
            };

            lock (_history)
            {
                _history.Add(r);
                if (_history.Count > 1000) _history.RemoveAt(0);
            }

            ReadingUpdated?.Invoke(this, r);
        }

        public void SetActuatorState(string name, bool on)
        {
            if (_actuators.ContainsKey(name)) _actuators[name] = on;
        }

        public bool GetActuatorState(string name)
        {
            return _actuators.TryGetValue(name, out var v) && v;
        }
    }
}
