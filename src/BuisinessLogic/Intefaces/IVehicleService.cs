using BusinessLogic.Models;

namespace BuisinessLogic.Intefaces
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDTO> GetAllVehicles();
        VehicleDTO GetVehicleById(int id);
        void AddVehicle(VehicleDTO vehicle);
        void Updatevehicle(VehicleDTO vehicle);
        void Deletevehicle(int id);
    }
}
