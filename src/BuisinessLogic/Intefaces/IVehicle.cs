namespace BuisinessLogic.Intefaces
{
    public interface IVehicle
    {
        public interface IVehicle
        {
            IEnumerable<VehicleDTO> GetAllVehicles();
            VehicleDTO GetVehicleById(int id);
            void AddVehicle(Vehicle vehicle);
            void Updatevehicle(int id, Vehicle vehicle);
            void Deletevehicle(int id);
        }
    }
}
