using Data.Models;

namespace Data.Intefaces
{
    public interface IFuelLog
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(int id);
        FuelLog GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLog fuelLog);
        void UpdateFuelLog(FuelLog fuelLog);
        void DeleteFuelLog(int id);
    }
}
