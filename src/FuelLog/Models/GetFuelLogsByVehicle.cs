using FuelLogAPI.Models.Enums;

namespace FuelLogAPI.Models
{
    public class GetFuelLogsByVehicleId
    {
        public int VehicleId;
        public AmountFilledUnit AmountFilledUnit;
        public CostCurrency CostCurrency;
        public OdometerUnit OdometerUnit;
    }
}