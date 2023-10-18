using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Data.Models;


namespace Data.Interfaces.Implementation
{
    public class VehicleService : IVehicleServiceData
    {
        private List<VehicleData> _vehicles;
        private const string filePath = @"";
        public VehicleService()
        {

            _vehicles = JsonSerializer.Deserialize<List<VehicleData>>(File.Open(filePath, FileMode.OpenOrCreate));
        }

        private void Save()
        {
            File.Open(filePath, FileMode.Truncate);
            File.WriteAllText(filePath, JsonSerializer.Serialize(_vehicles));
        }



        public void AddVehicle(VehicleData vehicle)
        {
            _vehicles.Add(vehicle);
            Save();
            
        }

        public void DeleteVehicle(int id)
        {
            var index = _vehicles.FindIndex(x => x.Id == id);
            _vehicles.RemoveAt(index);
            Save();
        }

        public IEnumerable<VehicleData> GetAllVehicles()
        {
            return _vehicles;

        }

        public VehicleData GetVehicleById(int id)
        {
            return _vehicles.Single(x => x.Id == id);
        }

        public void UpdateVehicle(VehicleData updatedVehicle)
        {
            var index = _vehicles.FindIndex(x => x.Id == updatedVehicle.Id);
            _vehicles.RemoveAt(index);
            _vehicles.Add(updatedVehicle);
            Save();
        }
    }
}
