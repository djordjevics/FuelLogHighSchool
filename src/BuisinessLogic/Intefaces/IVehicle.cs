using BusinessLogic.Models;

namespace BuisinessLogic.Intefaces
{
    public interface IVehicle
    {
        IEnumerable<VehicleDTO> GetAllVehicles();
        VehicleDTO GetVehicleById(int id);
        void AddVehicle(VehicleDTO vehicle);
        void Updatevehicle(VehicleDTO vehicle);
        void Deletevehicle(int id);
    }
}
