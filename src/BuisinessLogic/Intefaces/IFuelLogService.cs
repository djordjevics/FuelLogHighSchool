using BuisinessLogic.Models;

namespace BuisinessLogic.Intefaces
{
    public interface IFuelLogService
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(GetFuelLogsByVehicleId getFuelLogsByVehicleId);
        FuelLog GetFuelLogById(GetFuelLogById getFuelLogById);
        void AddFuelLogToVehicle(CreateFuelLog createFuelLog);
        void UpdateFuelLog(UpdateFuelLogRequest updateFuelLogRequest);
        void DeleteFuelLog(DeleteFuelLogRequest deleteFuelLogRequest);
    }
}
