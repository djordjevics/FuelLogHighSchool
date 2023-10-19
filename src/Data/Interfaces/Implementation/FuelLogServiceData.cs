using System.Runtime.CompilerServices;
using System.Text.Json;
using Data.Models;

namespace Data.Interfaces.Implementation
{
    public class FuelLogServiceData : IFuelLogServiceData
    {
        private List<FuelLogData> _fuelLogs;
        private const string filePath = @"FuelLog.json";

        public FuelLogServiceData()
        {
            try
            {
                FileStream file = File.Open(filePath, FileMode.Open);
                _fuelLogs = JsonSerializer.Deserialize<List<FuelLogData>>(file);
                file.Close();

            }
            catch (Exception ex)
            {
                FileStream file = File.Open(filePath, FileMode.CreateNew);
                file.Close();

                _fuelLogs = new();
                Save();
            }
        }

        private void Save()
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(_fuelLogs));

        }
        public void AddFuelLogToVehicle(FuelLogData fuelLog)
        {
            fuelLog.Id = _fuelLogs.Count;
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
