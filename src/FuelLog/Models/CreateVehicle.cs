using FuelLog.Models.Enums;

namespace FuelLog.Models
{
    public class CreateVehicle
    {
        public string Model;
        public string LicensePlate;
        public string Color;
        public FuelType FuelType;
        public int WheelCount;
    }
}