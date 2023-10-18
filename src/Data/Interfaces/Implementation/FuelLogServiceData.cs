using System.Runtime.CompilerServices;
using System.Text.Json;
using Data.Models;

namespace Data.Interfaces.Implementation
{
    public class FuelLogService : IFuelLogServiceData
    {
        private List<FuelLogData> _fuelLogs;
        private const string filePath = @"";

        public FuelLogService() 
        {
            _fuelLogs = JsonSerializer.Deserialize<List<FuelLogData>>(File.Open(filePath, FileMode.OpenOrCreate));
        }

        private void Save()
        {
            File.Open(filePath, FileMode.Truncate);
            File.WriteAllText(filePath, JsonSerializer.Serialize(_fuelLogs));
        }
        public void AddFuelLogToVehicle(FuelLogData fuelLog)
        {
            _fuelLogs.Add(fuelLog);
            Save();
        }

        public void DeleteFuelLog(int id)
        {
            var index = _fuelLogs.FindIndex(x => x.Id == id);
            _fuelLogs.RemoveAt(index);
            Save();
        }

        public IEnumerable<FuelLogData> GetAllFuelLogs()
        {
            return _fuelLogs;
        }

        public IEnumerable<FuelLogData> GetAllFuelLogsByVehicleId(int id)
        {
            return _fuelLogs.FindAll(x => x.VehicleId == id);
        }

        public FuelLogData GetFuelLogById(int id)
        {
            return _fuelLogs.Single(x => x.Id == id);
        }

        public void UpdateFuelLog(FuelLogData updatedFuelLog)
        {
            var index = _fuelLogs.FindIndex(x => x.Id == updatedFuelLog.Id);
            _fuelLogs.RemoveAt(index);
            _fuelLogs.Add(updatedFuelLog);
            Save();
        }
    }
}
