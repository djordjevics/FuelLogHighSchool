using BusinessLogic.Models;

<<<<<<<< HEAD:src/BuisinessLogic/Intefaces/Implementation/VehicleService.cs
namespace BuisinessLogic.Intefaces.Implementation
========
namespace BusinessLogic.Interfaces.Implementations
>>>>>>>> main:src/BuisinessLogic/Interfaces/Implementations/VehicleService.cs
{
    public class VehicleService : IVehicleService
    {
        public void AddVehicle(CreateVehicle createVehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(DeleteVehicleRequest deleteVehicleRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleById(GetVehicleById getVehicleById)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(UpdateVehicleRequest updateVehicleRequest)
        {
            throw new NotImplementedException();
        }
    }
}
