using Data.Models;

namespace Data.Intefaces
{
    public interface IFuelLogService
    {
        IEnumerable<FuelLogData> GetAllFuelLogs();
        IEnumerable<FuelLogData> GetAllFuelLogsByVehicleId(int id);
        FuelLogData GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLogData fuelLog);
        void UpdateFuelLog(FuelLogData fuelLog);
        void DeleteFuelLog(int id);
    }
}
