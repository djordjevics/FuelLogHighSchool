using BusinessLogic.Models;

namespace BuisinessLogic.Intefaces
{
    public interface IFuelLog
    {
        IEnumerable<FuelLogDTO> GetAllFuelLogs();
        IEnumerable<FuelLogDTO> GetAllFuelLogsByVehicleId(int id);
        FuelLogDTO GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLogDTO fuelLog);
        void UpdateFuelLog(FuelLogDTO fuelLog);
        void DeleteFuelLog(int id);
    }
}
