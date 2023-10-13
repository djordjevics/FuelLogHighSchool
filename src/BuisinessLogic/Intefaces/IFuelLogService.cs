using BusinessLogic.Models;
using FuelLog;

namespace BuisinessLogic.Intefaces
{
    public interface IFuelLogService
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(int id);
        FuelLog GetFuelLogById(int id);
        void AddFuelLogToVehicle(CreateFuelLog fuelLog);
        void UpdateFuelLog(UpdateFuelLogRequest fuelLog);
        void DeleteFuelLog(int id);
    }
}
