using System;
using System.Collections.Generic;
using SmartGreenhouse.Models;

namespace SmartGreenhouse.Services
{
    public interface ISensorService
    {
        event EventHandler<SensorReading>? ReadingUpdated;
        IReadOnlyList<SensorReading> History { get; }
        void Start();
        void Stop();
        void SetActuatorState(string name, bool on);
        bool GetActuatorState(string name);
    }
}
