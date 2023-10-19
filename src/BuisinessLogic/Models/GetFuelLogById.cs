using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class GetFuelLogById
    {
        public int Id { get; set; }
        public AmountFilledUnit AmountFilledUnit { get; set; }
        public CostCurrency CostCurrency { get; set; }
        public OdometerUnit OdometerUnit { get; set; }
    }
}