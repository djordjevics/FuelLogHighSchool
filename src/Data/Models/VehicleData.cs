using System.ComponentModel;

namespace Data.Models
{
    public class VehicleData
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int WheelCount { get; set; }
    }

}