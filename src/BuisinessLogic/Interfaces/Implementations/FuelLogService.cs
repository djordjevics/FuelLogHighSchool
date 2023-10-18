using BusinessLogic.Mappers;
using BusinessLogic.Models;
using Data.Interfaces;
using Data.Interfaces.Implementation;

namespace BusinessLogic.Interfaces.Implementations
{
    public class FuelLogService : IFuelLogService
    {
        private IFuelLogServiceData _fuelLogService = new FuelLogServiceData();

        public void AddFuelLogToVehicle(CreateFuelLog createFuelLog)
        {
            _fuelLogService.AddFuelLogToVehicle();
        }

        public void DeleteFuelLog(DeleteFuelLogRequest deleteFuelLogRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuelLog> GetAllFuelLogs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FuelLog> GetAllFuelLogsByVehicleId(GetFuelLogsByVehicleId getFuelLogsByVehicleId)
        {
            throw new NotImplementedException();
        }

        public FuelLog GetFuelLogById(GetFuelLogById getFuelLogById)
        {
            throw new NotImplementedException();
        }

        public void UpdateFuelLog(UpdateFuelLogRequest updateFuelLogRequest)
        {
            throw new NotImplementedException();
        }
    }
}
