using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(GetVehicleById getVehicleById);
        void AddVehicle(CreateVehicle createVehicle);
        void UpdateVehicle(UpdateVehicleRequest updateVehicleRequest);
        void DeleteVehicle(DeleteVehicleRequest deleteVehicleRequest);
    }
}
