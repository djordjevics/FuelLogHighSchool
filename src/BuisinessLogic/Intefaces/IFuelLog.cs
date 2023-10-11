namespace BuisinessLogic.Intefaces
{
    public interface IFuelLog
    {
        IEnumerable<FuelLogDTO> GetAllFuelLogs();
        IEnumerable<FuelLogDTO> GetAllFuelLogsByVehicleId(int id);
        FuelLogDTO GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLogDTO fuelLog);
        void UpdateFuelLog(UpdateFuelLogRequest fuelLog);
        void DeleteFuelLog(int id);
    }
}
