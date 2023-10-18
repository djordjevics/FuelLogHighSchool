using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class FuelLog
    {
        public int Id;
        public double Odometer;
        public OdometerUnit OdometerUnit;
        public double AmountFilled;
        public AmountFilledUnit AmountFilledUnit;
        public double Cost;
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}