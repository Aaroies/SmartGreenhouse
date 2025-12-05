using System;

namespace SmartGreenhouse.Models
{
    public class SensorReading
    {
        public DateTime Timestamp { get; set; }
        public double TemperatureC { get; set; }
        public double Humidity { get; set; }
        public double SoilMoisture { get; set; }
    }
}
