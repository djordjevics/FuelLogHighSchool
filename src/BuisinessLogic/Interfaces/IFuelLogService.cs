using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
{
    public interface IFuelLogService
    {
        IEnumerable<FuelLog> GetAllFuelLogs(string amountUnit, string odometerUnit, string costCurrency);
        IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(GetFuelLogsByVehicleId getFuelLogsByVehicleId);
        FuelLog GetFuelLogById(GetFuelLogById getFuelLogById);
        void AddFuelLogToVehicle(CreateFuelLog createFuelLog);
        void UpdateFuelLog(UpdateFuelLogRequest updateFuelLogRequest);
        void DeleteFuelLog(DeleteFuelLogRequest deleteFuelLogRequest);
    }
}
