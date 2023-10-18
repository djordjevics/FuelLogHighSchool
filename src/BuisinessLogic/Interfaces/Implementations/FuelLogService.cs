using BusinessLogic.Mappers;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces.Implementations
{
    public class FuelLogService : IFuelLogService
    {
        public void AddFuelLogToVehicle(CreateFuelLog createFuelLog)
        {
            throw new NotImplementedException();
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
