using BusinessLogic.Mappers;
using BusinessLogic.Models;
using Data.Interfaces;
using Data.Interfaces.Implementation;

namespace BusinessLogic.Interfaces.Implementations
{
    public class FuelLogService : IFuelLogService
    {
        private readonly IFuelLogServiceData _fuelLogServiceData = new FuelLogServiceData();

        public void AddFuelLogToVehicle(CreateFuelLog createFuelLog)
        {
            _fuelLogServiceData.AddFuelLogToVehicle(createFuelLog.ToFuelLogDTO().ToFuelLogData());
        }

        public void DeleteFuelLog(DeleteFuelLogRequest deleteFuelLogRequest)
        {
            _fuelLogServiceData.DeleteFuelLog(deleteFuelLogRequest.Id);
        }

        public IEnumerable<FuelLog> GetAllFuelLogs()
        {
            List<FuelLog> fuelLogs = new();
            foreach (var el in _fuelLogServiceData.GetAllFuelLogs())
            {
                fuelLogs.Add(el.ToFuelLogDTO().ToFuelLog());
            }
            return fuelLogs;
        }

        public IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(GetFuelLogsByVehicleId getFuelLogsByVehicleId)
        {
            List<FuelLog> fuelLogs = new();
            foreach (var el in _fuelLogServiceData.GetAllFuelLogsByVehicleId(getFuelLogsByVehicleId.VehicleId))
            {
                fuelLogs.Add(el.ToFuelLogDTO().ToFuelLog());
            }
            return fuelLogs;
        }

        public FuelLog GetFuelLogById(GetFuelLogById getFuelLogById)
        {
            return _fuelLogServiceData.GetFuelLogById(getFuelLogById.Id).ToFuelLogDTO().ToFuelLog();
        }

        public void UpdateFuelLog(UpdateFuelLogRequest updateFuelLogRequest)
        {
            _fuelLogServiceData.UpdateFuelLog(updateFuelLogRequest.toFuelLogDTO().ToFuelLogData());
        }
    }
}
