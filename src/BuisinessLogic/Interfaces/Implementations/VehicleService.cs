using BusinessLogic.Mappers;
using BusinessLogic.Models;
using BusinessLogic.Models.Enums;
using Data.Interfaces;
using Data.Interfaces.Implementation;

namespace BusinessLogic.Interfaces.Implementations;

public class VehicleService : IVehicleService
{
    private readonly IVehicleServiceData _vehicleServiceData = new VehicleServiceData();
    private IFuelLogService _fuelLogService = new FuelLogService();

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

    public double AvgFuelConsumption(int vehicleId)
    {
        var logs = _fuelLogService.GetAllFuelLogsByVehicleId(new() { VehicleId = vehicleId});

        double fuelConsumptedSum = logs.Sum(x => x.AmountFilled);

        return logs.Last().Odometer / fuelConsumptedSum; 

    }

    public double AvgFuelConsumptionBetweenFuelLogs(int vehicleId, int fuelLog1Id, int fuelLog2Id)
    {
        var log1 = _fuelLogService.GetFuelLogById(new() { Id = fuelLog1Id });
        var log2 = _fuelLogService.GetFuelLogById(new() { Id = fuelLog2Id });

        var logsFromVehicle = _fuelLogService.GetAllFuelLogsByVehicleId(new() { VehicleId = vehicleId });
        List<FuelLog> logs = new();

        for (int i = fuelLog1Id; i <= fuelLog2Id; i++)
        {
            if (logsFromVehicle.Single(x => x.Id == i) != null)
            {
                logs.Add(logsFromVehicle.Single(x => x.Id == i));
            }
        }

        double fuelConsumptedSum = logs.Sum(x => x.AmountFilled);

        return (log2.Odometer - log1.Odometer) / fuelConsumptedSum;
    }
}
