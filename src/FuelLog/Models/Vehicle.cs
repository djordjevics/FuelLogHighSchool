using FuelLog.Models.Enums;

namespace FuelLog.Models
{
    public class Vehicle
    {
        public int Id;
        public string LicensePlate;
        public string Model;
        public string Color;
        public FuelType FuelType;
        public int WheelCount;
    }
}