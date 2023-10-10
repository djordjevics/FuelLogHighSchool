namespace Data.Intefaces
{
    internal interface IFuelLog
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<IFuelLog> GetAllFuelLogsByVehicleId(int id);
        FuelLog GetFuelLogById(int id);
        void AddFuelLogToVehicle(int id, FuelLog fuel_log);
        void UpdateFuelLog(int id, FuelLog fuel_log);
        void DeleteFuelLog(int id);
    }
}
