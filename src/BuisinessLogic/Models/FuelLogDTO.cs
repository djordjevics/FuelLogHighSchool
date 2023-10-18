using BusinessLogic.Models.Enums;

namespace BusinessLogic.Models
{
    public class FuelLogDTO
    {
        private double _km;
        private double _liters;
        private double _rsd;

        private const double ExchangeRate = 117.18;
        private const double KmToMi = 1.609;
        private const double LitersToImpgallons = 4.546;
        private const double LitersToUsgallons = 0.246;

        public int Id;
        public double Odometer
        {
            get {
                if (OdometerUnit == OdometerUnit.MI) { return _km / KmToMi; }
                else { return _km; }
            }
            set {
                if (OdometerUnit == OdometerUnit.MI) { _km = value * KmToMi; }
                else { _km = value; }
            }
        }
        public double OdometerInKm
        {
            get { return _km; }
        }
        public OdometerUnit OdometerUnit;
        public double AmountFilled
        {
            get { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { return _liters / LitersToImpgallons; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { return _liters * LitersToUsgallons; }
                else { return _liters; }
            }
            set { 
                if (AmountFilledUnit == AmountFilledUnit.IMPGALLONS) { _liters = value * LitersToImpgallons; }
                else if (AmountFilledUnit == AmountFilledUnit.USGALLONS) { _liters = value / LitersToUsgallons; }
                else { _liters = value; }
            }
        }
        public double AmountInLiters
        {
            get { return _liters; }
        }
        public AmountFilledUnit AmountFilledUnit;
        public double Cost
        {
            get { 
                if (CostCurrency == CostCurrency.EUR) { return _rsd / ExchangeRate; }
                else return _rsd;
            }
            set {
                if (CostCurrency == CostCurrency.EUR) { _rsd = value * ExchangeRate; }
                else _rsd = value;
            }
        }
        public double CostInRsd
        {
            get { return _rsd; }
        }
        public CostCurrency CostCurrency;
        public int VehicleId;
    }
}