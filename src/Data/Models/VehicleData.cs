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
            var arr  = str.Split(",");
            return new()
            {
                Id = int.Parse(arr[0]),
                Model = arr[1],
                LicensePlate = arr[2],
                Color = arr[3],
                FuelType = arr[4],
                WheelCount = int.Parse(arr[5])
            };
        }
    }

}