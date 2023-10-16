using BusinessLogic.Models;
using BusinessLogic.Models.Enums;
using Data.Models;

namespace BusinessLogic.Mappers
{
    public static class DataToBusiness
    {
        public static FuelLogDTO ToFuelLogDTO(this FuelLogData data)
        {
            return new FuelLogDTO
            {
                Id = data.Id,
                Odometer = data.Odometer,
                AmountFilled = data.AmountFilled,
                Cost = data.Cost,
                VehicleId = data.VehicleId
            };
        }

        public static VehicleDTO ToVehicleDTO(this VehicleData data)
        {
            return new VehicleDTO
            {
                Id = data.Id,
                Model = data.Model,
                Color = data.Color,
                LicensePlate = data.LicensePlate,
                WheelCount = data.WheelCount,
                FuelType = Enum.Parse<FuelType>(data.FuelType)
            };
        }
    }
}
