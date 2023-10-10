using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuisinessLogic.IVehicle;

namespace BuisinessLogic
{
    public interface IVehicle
    {
        public interface IVehicle
        {
            IEnumerable<Vehicle> GetAllVehicles();
            Vehicle GetVehicleById(int id);
            void AddVehicle(Vehicle v);
            void Updatevehicle(int id, Vehicle v);
            void Deletevehicle(int id);
        }
    }
}
