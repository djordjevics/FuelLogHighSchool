using System.Linq;
using Data.Models;

namespace Data.Intefaces.Implementation
{
    public class VehicleService : IVehicleService
    {
        public string filePath = @".\Vehicles.csv";
        public void AddVehicle(VehicleData vehicle)
        {
            if (!File.Exists(filePath))
            {
                StreamWriter streamWriter = File.CreateText(filePath);
                streamWriter.WriteLine(vehicle.ToString());
                streamWriter.Close();
            }
            else
            {
                StreamWriter streamWriter = new(filePath);
                streamWriter.WriteLine(vehicle.ToString());
                streamWriter.Close();
            }
        }

        public void DeleteVehicle(int id)
        {
            if (!File.Exists(filePath))
            {
                throw new NotImplementedException();
            }
            else
            {
                StreamWriter streamWriter = new(filePath);
                StreamReader streamReader = new(filePath);
                List<string> list = new() ?streamReader.ReadToEnd().ToList();
                streamReader.Close();
                foreach(string item in list)
                {
                    if (int.Parse(item.Split(',')[0]) == id)
                    {
                        list.Remove(item);
                        break;
                    }
                }
                streamWriter.WriteLine(list.ToArray());
                streamWriter.Close();
            }
        }

        public IEnumerable<VehicleData> GetAllVehicles()
        {
            StreamReader streamReader = new(filePath);
            List<object> list = new() ?streamReader.ReadToEnd().ToList();
            VehicleData vehicle = new();
            foreach(string item in list)
            {
                list.Remove(item);
                list.Add(vehicle.ToObject(item));
            }
            return list;

        }

        public VehicleData GetVehicleById(int id)
        {
            StreamReader streamReader = new(filePath);
            List<object> list = new() ? streamReader.ReadToEnd().ToList();
            VehicleData vehicle = new();
            foreach (string item in list)
            {
                if (int.Parse(item.Split(",")[0]) == id)
                {
                    return vehicle.ToObject(item);
                }
            }
            throw new NotImplementedException();
        }

        public void UpdateVehicle(VehicleData updatedVehicle)
        {
            if (!File.Exists(filePath))
            {
                throw new NotImplementedException();
            }
            else
            {
                StreamWriter streamWriter = new(filePath);
                StreamReader streamReader = new(filePath);
                List<string> list = new() ? streamReader.ReadToEnd().ToList();
                streamReader.Close();
                foreach (string item in list)
                {
                    if (int.Parse(item.Split(',')[0]) == updatedVehicle.Id)
                    {
                        list.Remove(item);
                        list.Add(updatedVehicle.ToString());
                        break;
                    }
                }
                streamWriter.WriteLine(list.ToArray());
                streamWriter.Close();
            }
        }
    }
}
