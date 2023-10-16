using BusinessLogic.Models;
using BusinessLogic.Models.Enums;

namespace BusinessLogic.Mappers
{
    public static class BusinessToAPI
    {
        public static Vehicle toVehicle(this VehicleDTO dto)
        {
            return new Vehicle
            {
                Id = dto.Id,
                Model = dto.Model,
                Color = dto.Color,
                LicensePlate = dto.LicensePlate,
                FuelType = dto.FuelType,
                WheelCount = dto.WheelCount
            };
        }

        public static FuelLog toFuelLog(this FuelLogDTO dto)
        {
            return new FuelLog
            {
                Id = dto.Id,
                AmountFilled = dto.AmountFilled,
                AmountFilledUnit = dto.AmountFilledUnit,
                Odometer = dto.Odometer,
                OdometerUnit = dto.OdometerUnit,
                Cost = dto.Cost,
                CostCurrency = dto.CostCurrency,
                VehicleId = dto.VehicleId
            };
        }
    }
}
