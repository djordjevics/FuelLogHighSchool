namespace BusinessLogic
{
    public static class Converter
    {
        public static double KmToMi(this double Km)
        {
            return Km / 1.609;
        }
        public static double MiToKm(this double Mi)
        {
            return Mi * 1.609;
        }
        public static double EurToRsd(this double Eur)
        {
            return Eur * 117.18;
        }
        public static double RsdToEur(this double Rsd)
        {
            return Rsd / 117.18;
        }
        public static double LitersToUsGallons(this double Liters)
        {
            return Liters * 0.264;
        }
        public static double LitersToImpGallons(this double Liters)
        {
            return Liters / 4.546;
        }
        public static double UsGallonsToLiters(this double Gallons)
        {
            return Gallons / 0.264;
        }
        public static double ImpGallonsToLiters(this double Gallons)
        {
            return Gallons * 4.546;
        }
    }
}
