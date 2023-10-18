using Data.Models;

namespace Data.Intefaces.Implementation
{
    public class FuelLogService : IFuelLogService
    {
        public string file_path = @".\FuelLogs.csv";
        public void AddFuelLogToVehicle(FuelLogData fuelLog)
        {
            throw new NotImplementedException();
        }

        public void DeleteFuelLog(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuelLogData> GetAllFuelLogs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuelLogData> GetAllFuelLogsByVehicleId(int id)
        {
            throw new NotImplementedException();
        }

        public FuelLogData GetFuelLogById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateFuelLog(FuelLogData fuelLog)
        {
            throw new NotImplementedException();
        }
    }
}
