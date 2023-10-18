namespace Data.Models
{
    public class FuelLogData
    {
        public int Id;
        public int Odometer;
        public int AmountFilled;
        public int Cost;
        public int VehicleId;

        public override string ToString()
        {
            return ( Id + "," + Odometer + "," + AmountFilled + "," + Cost + "," + VehicleId);
        }
    }
}