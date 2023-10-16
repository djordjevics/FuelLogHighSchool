using FuelLogAPI.Models.Enums;

namespace FuelLogAPI.Models
{
    public class GetFuelLogById
    {
        public int Id;
        public AmountFilledUnit AmountFilledUnit;
        public CostCurrency CostCurrency;
        public OdometerUnit OdometerUnit;
    }
}