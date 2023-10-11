namespace BuisinessLogic.Intefaces
{
    public interface IVehicle
    {
        IEnumerable<VehicleDTO> GetAllVehicles();
        VehicleDTO GetVehicleById(int id);
        void AddVehicle(VehicleDTO vehicle);
        void Updatevehicle(UpdateVehicleRequest vehicle);
        void Deletevehicle(int id);
    }
}
