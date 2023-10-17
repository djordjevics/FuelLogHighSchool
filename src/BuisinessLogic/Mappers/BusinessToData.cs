using BusinessLogic.Models.Enums;
using BusinessLogic.Models;
using Data.Models;

namespace BusinessLogic.Mappers
{
    public static class BusinessToData
    {

        public static FuelLogData ToFuellogData(this FuelLogDTO dto)
        {
            return new FuelLogData
            {
                Id = dto.Id,
                Odometer = dto.km,
                AmountFilled = dto.liters,
                Cost = dto.rsd,
                VehicleId = dto.VehicleId
            };
        }

        public static VehicleData ToVehicleData(this VehicleDTO dto)
        {
            return new VehicleData
            {
                Id = dto.Id,
                Model = dto.Model,
                LicensePlate = dto.LicensePlate,
                Color = dto.Color,
                FuelType = dto.FuelType.ToString()
            };
        }
    }
}
