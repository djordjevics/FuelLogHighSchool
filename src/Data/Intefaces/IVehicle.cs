namespace Data.Intefaces
{
    internal interface IVehicle
    {
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle GetVehicleById(int id);
        void AddVehicle(Vehicle vehicle);
        void Updatevehicle(int id, Vehicle vehicle);
        void Deletevehicle(int id);
    }
}
