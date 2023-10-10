namespace BuisinessLogic.Intefaces
{
    public interface IFuelLog
    {
        public interface IFuelLog
        {
            IEnumerable<FuelLogDTO> GetAllFuelLogs();
            IEnumerable<FuelLogDTO> GetAllFuelLogsByVehicleId(int id);
            FuelLogDTO GetFuelLogById(int id);
            void AddFuelLogToVehicle(int id, FuelLog fuel_log);
            void UpdateFuelLog(int id, FuelLog fuel_log);
            void DeleteFuelLog(int id);
        }
    }
}
