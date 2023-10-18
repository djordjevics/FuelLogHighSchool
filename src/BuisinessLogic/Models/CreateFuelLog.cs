using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class CreateFuelLog
    {
        public double Odometer { get; set; }
        public OdometerUnit OdometerUnit { get; set; }
        public double AmountFilled { get; set; }
        public AmountFilledUnit AmountFilledUnit { get; set; }
        public double Cost {  get; set; }
        public CostCurrency CostCurrency { get; set; }
        public int VehicleId { get; set; }
    }
}