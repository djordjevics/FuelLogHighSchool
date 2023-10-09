using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisinessLogic
{
    public interface IVehicle
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(int id);
        void AddVehicle(Vehicle v);
        void Updatevehicle(int id, Vehicle v);
        void Deletevehicle(int id);
    }

    public interface IFuelLog
    {
        IEnumerable<FuelLog> GetAllFuelLogs();
        IEnumerable<IFuelLog> GetAllFuelLogsByVehicleId(int id);
        FuelLog GetFuelLogById(int id);
        void AddFuelLogToVehicle(int id, FuelLog fuel_log);
        void UpdateFuelLog(int id, FuelLog fuel_log);
        void DeleteFuelLog(int id);
    }
}
