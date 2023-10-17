using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class FuelLogDTO
    {
        private double _km;
        private double _liters;
        private double _rsd;

        public int Id;
        public double Odometer
        {
            get {
                if (OdometerUnit == OdometerUnit.MI) { return _km / 1.609; }
                else { return _km; }
            }
            set {
                if (OdometerUnit == OdometerUnit.MI) { _km = value * 1.609; }
                else { _km = value; }
            }
        }
        public OdometerUnit OdometerUnit;
        public double AmountFilled
        {
            get { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { return _liters / 4.546; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { return _liters * 0.246; }
                else { return _liters; }
            }
            set { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { _liters = value * 4.546; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { _liters = value / 0.246; }
                else { _liters = value; }
            }
        }
        public AmountFilledUnit AmountFilledUnit;
        public double Cost
        {
            get { 
                if (CostCurrency == CostCurrency.EUR) { return _rsd / 117.18; }
                else return _rsd;
            }
            set {
                if (CostCurrency == CostCurrency.EUR) { _rsd = value * 117.18; }
                else _rsd = value;
            }
        }
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}