namespace Data.Models
{
    public class FuelLogData
    {
        public int Id { get; set; }
        public double Odometer { get; set; }
        public double AmountFilled { get; set; }
        public double Cost {  get; set; }
        public int VehicleId { get; set; }
    }
}