namespace Data.Intefaces
{
    public interface IVehicle
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(int id);
        void AddVehicle(Vehicle vehicle);
        void Updatevehicle(UpdateVehicleRequest vehicle);
        void Deletevehicle(int id);
    }
}
