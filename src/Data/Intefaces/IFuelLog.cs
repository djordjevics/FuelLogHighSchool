namespace Data.Intefaces
{
    public interface IFuelLog
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<IFuelLog> GetAllFuelLogsByVehicleId(int id);
        FuelLog GetFuelLogById(int id);
        void AddFuelLogToVehicle(FuelLog fuel_log);
        void UpdateFuelLog(FuelLog fuel_log);
        void DeleteFuelLog(int id);
    }
}
