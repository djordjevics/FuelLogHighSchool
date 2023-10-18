using BusinessLogic.Mappers;
using BusinessLogic.Models;
using Data.Interfaces;
using Data.Interfaces.Implementation;

namespace BusinessLogic.Interfaces.Implementations;

public class VehicleService : IVehicleService
{
    private readonly IVehicleServiceData _vehicleServiceData = new VehicleServiceData();

    public void AddVehicle(CreateVehicle createVehicle)
    {
        _vehicleServiceData.AddVehicle(createVehicle.ToVehicleDTO().ToVehicleData());
    }

    public void DeleteVehicle(DeleteVehicleRequest deleteVehicleRequest)
    {
        _vehicleServiceData.DeleteVehicle(deleteVehicleRequest.Id);
    }

    public IEnumerable<Vehicle> GetAllVehicles()
    {
        List<Vehicle> vehicles = new();
        foreach (var el in _vehicleServiceData.GetAllVehicles())
        {
            vehicles.Add(el.ToVehicleDTO().ToVehicle());
        }

        return vehicles;
    }

    public Vehicle GetVehicleById(GetVehicleById getVehicleById)
    {
        return _vehicleServiceData.GetVehicleById(getVehicleById.Id).ToVehicleDTO().ToVehicle();
    }

    public void UpdateVehicle(UpdateVehicleRequest updateVehicleRequest)
    {
        _vehicleServiceData.UpdateVehicle(updateVehicleRequest.ToVehicleDTO().ToVehicleData());
    }
}
