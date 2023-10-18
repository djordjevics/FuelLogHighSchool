using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class CreateVehicle
    {
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public FuelType FuelType { get; set; }
        public int WheelCount { get; set; }
    }
}