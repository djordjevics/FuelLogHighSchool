using System.ComponentModel;

namespace Data.Models
{
    public class VehicleData
    {
        public int Id;
        public string Model;
        public string LicensePlate;
        public string Color;
        public string FuelType;
        public int WheelCount;

        public override string ToString()
        {
                return (Id + "," + Model + "," + LicensePlate + "," + Color + "," + FuelType + "," + WheelCount);
        }

        public VehicleData ToObject(string str)
        {
            return new()
            {
                Id = int.Parse(str.Split(",")[0]),
                Model = str.Split(",")[1],
                LicensePlate = str.Split(",")[2],
                Color = str.Split(",")[3],
                FuelType = str.Split(",")[4],
                WheelCount = int.Parse(str.Split(",")[5])
            };
        }
    }

}