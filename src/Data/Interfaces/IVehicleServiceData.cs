using Data.Models;

namespace Data.Intefaces
{
    public interface IVehicleServiceData
    {
        IEnumerable<VehicleData> GetAllVehicles();
        VehicleData GetVehicleById(int id);
        void AddVehicle(VehicleData vehicle);
        void UpdateVehicle(VehicleData vehicle);
        void DeleteVehicle(int id);
    }
}
