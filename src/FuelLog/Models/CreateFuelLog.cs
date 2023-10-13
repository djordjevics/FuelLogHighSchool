using FuelLogAPI.Models.Enums;

namespace FuelLogAPI.Models
{
    public class CreateFuelLog
    {
        public int Odometer;
        public OdometerUnit OdometerUnit;
        public int AmountFilled;
        public AmountFilledUnit AmountFilledUnit;
        public int Cost;
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}