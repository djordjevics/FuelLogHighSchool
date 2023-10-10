namespace BusinessLogic
{
    public class VehicleDTO
    {
        public int Id;
        public string LicensePlate;
        public string Model;
        public string Color;
        public enum FuelType
        {
            diesel,
            petrol,
            cng,
            lpg
        }
        public int WheelCount;
    }
}