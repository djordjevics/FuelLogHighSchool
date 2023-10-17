using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class FuelLogDTO
    {
        public double km;
        public double liters;
        public double rsd;

        public int Id;
        public double Odometer
        {
            get {
                if (OdometerUnit == OdometerUnit.MI) { return km / 1.609; }
                else { return km; }
            }
            set {
                if (OdometerUnit == OdometerUnit.MI) { km = value * 1.609; }
                else { km = value; }
            }
        }
        public OdometerUnit OdometerUnit;
        public double AmountFilled
        {
            get { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { return liters / 4.546; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { return liters * 0.246; }
                else { return liters; }
            }
            set { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { liters = value * 4.546; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { liters = value / 0.246; }
                else { liters = value; }
            }
        }
        public AmountFilledUnit AmountFilledUnit;
        public double Cost
        {
            get { 
                if (CostCurrency == CostCurrency.EUR) { return rsd / 117.18; }
                else return rsd;
            }
            set {
                if (CostCurrency == CostCurrency.EUR) { rsd = value * 117.18; }
                else rsd = value;
            }
        }
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}