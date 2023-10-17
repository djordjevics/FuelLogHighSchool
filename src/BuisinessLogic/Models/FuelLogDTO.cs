using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class FuelLogDTO
    {
        public int Id;
        public int Odometer;
        public OdometerUnit OdometerUnit;
        public int AmountFilled;
        public AmountFilledUnit AmountFilledUnit;
        public int Cost;
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}