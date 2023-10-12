using BuisinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class VehicleDTO
    {
        public int Id;
        public string LicensePlate;
        public string Model;
        public string Color;
        public FuelType FuelType;
        public int WheelCount;
    }
}