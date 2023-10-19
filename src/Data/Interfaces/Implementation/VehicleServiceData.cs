using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Data.Models;


namespace Data.Interfaces.Implementation
{
    public class VehicleServiceData : IVehicleServiceData
    {
        private List<VehicleData> _vehicles;
        private const string filePath = @"vehicles.json";
        public VehicleServiceData()
        {
            try
            {
                FileStream file = File.Open(filePath, FileMode.Open);
                _vehicles = JsonSerializer.Deserialize<List<VehicleData>>(file);
                file.Close();

            }catch (Exception ex)
            {
                FileStream file = File.Open(filePath, FileMode.CreateNew);
                file.Close();

                _vehicles = new();
                Save();
            }
        }

        private void Save()
        {
            File.WriteAllText(filePath, JsonSerializer.Serialize(_vehicles));
        }

        public void AddVehicle(VehicleData vehicle)
        {
            vehicle.Id = _vehicles.Count;
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
