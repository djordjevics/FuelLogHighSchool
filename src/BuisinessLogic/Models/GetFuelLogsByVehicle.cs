using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class GetFuelLogsByVehicleId
    {
        public int VehicleId { get; set; }
        public AmountFilledUnit AmountFilledUnit { get; set; }
        public CostCurrency CostCurrency { get; set; }
        public OdometerUnit OdometerUnit { get; set; }
    }
}