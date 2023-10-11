namespace BuisinessLogic.Intefaces
{
    public interface IFuelLog
    {
        IEnumerable<FuelLogDTO> GetAllFuelLogs();
        IEnumerable<FuelLogDTO> GetAllFuelLogsByVehicleId(int id);
        FuelLogDTO GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLogDTO fuel_log);
        void UpdateFuelLog(FuelLog fuel_log);
        void DeleteFuelLog(int id);
    }
}
