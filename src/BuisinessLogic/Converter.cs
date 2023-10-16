namespace BuisinessLogic
{
    public class Converter
    {
        public double KmToMi(double Km)
        {
            return Km / 1.609;
        }
        public double MiToKm(double Mi)
        {
            return Mi * 1.609;
        }
        public double EurToRsd(double Eur)
        {
            return Eur * 117.18;
        }
        public double RsdToEur(double Rsd)
        {
            return Rsd / 117.18;
        }
        public double LitersToUsGallons(double Liters)
        {
            return Liters * 0.264;
        }
        public double LitersToImpGallons(double Liters)
        {
            return Liters / 4.546;
        }
        public double UsGallonsToLiters(double Gallons)
        {
            return Gallons / 0.264;
        }
        public double ImpGallonsToLiters(double Gallons)
        {
            return Gallons * 4.546;
        }
    }
}
