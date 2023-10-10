namespace BusinessLogic
{
    public class FuelLogDTO
    {
        public int Id;
        public int Odometer;
        public enum OdometerUnit
        {
            km,
            mi
        }
        public int AmountFilled;
        public enum AmountFilledUnit
        {
            litres,
            usgallons,
            impgallons
        }
        public int Cost;
        public enum CostCurrency
        {
            eur,
            usd,
            gbp,
            aud,
            cad,
            czk,
            amd,
            dkk,
            huf,
            rsd,
            chf,
            pln,
            nok,
            sek,
            mkd,
            uah
            
        }
        public int VehicleId;
    }
}