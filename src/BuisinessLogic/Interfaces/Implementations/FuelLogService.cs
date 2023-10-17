<<<<<<<< HEAD:src/BuisinessLogic/Intefaces/Implementation/FuelLogService.cs
﻿using BuisinessLogic.Models;
using Data.Intefaces;
using Data.Intefaces.Implementation;

namespace BuisinessLogic.Intefaces.Implementation
========
﻿using BusinessLogic.Models;

namespace BusinessLogic.Interfaces.Implementations
>>>>>>>> main:src/BuisinessLogic/Interfaces/Implementations/FuelLogService.cs
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
