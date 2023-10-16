using BuisinessLogic.Models.Enums;

namespace BuisinessLogic.Models
{
    public class GetFuelLogsByVehicleId
    {
        public int VehicleId;
        public AmountFilledUnit AmountFilledUnit;
        public CostCurrency CostCurrency;
        public OdometerUnit OdometerUnit;
    }
}