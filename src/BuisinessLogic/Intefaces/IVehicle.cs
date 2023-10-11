namespace BuisinessLogic.Intefaces
{
    public interface IVehicle
    {
        IEnumerable<VehicleDTO> GetAllVehicles();
        VehicleDTO GetVehicleById(int id);
        void AddVehicle(VehicleDTO vehicle);
        void Updatevehicle(Vehicle vehicle);
        void Deletevehicle(int id);
    }
}
