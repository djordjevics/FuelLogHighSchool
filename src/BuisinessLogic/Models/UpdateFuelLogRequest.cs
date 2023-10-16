using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class UpdateFuelLogRequest
    {
        public FuelLog UpdatedFuelLog;
        public AmountFilledUnit AmountFilledUnit;
        public CostCurrency CostCurrency;
        public FuelType FuelType;
        public OdometerUnit OdometerUnit;
    }
}