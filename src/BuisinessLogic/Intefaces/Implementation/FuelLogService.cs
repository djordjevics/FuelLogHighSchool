using BuisinessLogic.Models;
using Data.Intefaces;
using Data.Intefaces.Implementation;

namespace BuisinessLogic.Intefaces.Implementation
{
    public class FuelLogService : IFuelLogService
    {
        private IFuelLogService _fuelLogService = new FuelLogService();

        public void AddFuelLogToVehicle(CreateFuelLog createFuelLog)
        {

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
