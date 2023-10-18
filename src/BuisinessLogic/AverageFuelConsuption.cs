using BusinessLogic.Models;


namespace BuisinessLogic
{
    public class AverageFuelConsuption
    {
        public double AverageFuelConsuptionForVehicle(int vehicleId)
        {

            float OdometerValue = 0;
            float FuelConsumpted = 0;

            List<FuelLogDTO> fuelLogs = 

            foreach (var log in fuelLogs)
            {
                OdometerValue += fuelLogs.Odometer(vehicleId);
                FuelConsumpted += fuelLogs.AmountFilled(vehicleId);
            }



            return (FuelConsumpted / OdometerValue);

        }
    }
}
