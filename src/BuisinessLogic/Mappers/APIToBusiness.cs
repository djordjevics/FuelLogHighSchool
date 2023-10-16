using BusinessLogic.Models.Enums;
using BusinessLogic.Models;

namespace BusinessLogic.Mappers
{
    public static class APIToBusiness
    {
        public static VehicleDTO ToVehicleDTO(this CreateVehicle req)
        {
            return new VehicleDTO
            {
                Color = req.Color,
                Model = req.Model,
                LicensePlate = req.LicensePlate,
                WheelCount = req.WheelCount,
                FuelType = req.FuelType
            };
        }

        public static VehicleDTO ToVehicleDTO(this UpdateVehicleRequest req)
        {
            return new VehicleDTO
            {
                Color = req.UpdatedVehicle.Color,
                Model = req.UpdatedVehicle.Model,
                LicensePlate = req.UpdatedVehicle.LicensePlate,
                WheelCount = req.UpdatedVehicle.WheelCount,
                FuelType = req.UpdatedVehicle.FuelType
            };
        }

        public static FuelLogDTO ToFuelLogDTO(this CreateFuelLog req)
        {
            return new FuelLogDTO
            {
                Odometer = req.Odometer,
                OdometerUnit = req.OdometerUnit,
                AmountFilled = req.AmountFilled,
                AmountFilledUnit = req.AmountFilledUnit,
                Cost = req.Cost,
                CostCurrency = req.CostCurrency,
                VehicleId = req.VehicleId
            };
        }

        public static FuelLogDTO toFuelLogDTO(this UpdateFuelLogRequest req)
        {
            return new FuelLogDTO
            {
                Odometer = req.UpdatedFuelLog.Odometer,
                OdometerUnit = req.UpdatedFuelLog.OdometerUnit,
                AmountFilled = req.UpdatedFuelLog.AmountFilled,
                AmountFilledUnit = req.UpdatedFuelLog.AmountFilledUnit,
                Cost = req.UpdatedFuelLog.Cost,
                CostCurrency = req.UpdatedFuelLog.CostCurrency,
                VehicleId = req.UpdatedFuelLog.VehicleId
            };
        }
    }
}
