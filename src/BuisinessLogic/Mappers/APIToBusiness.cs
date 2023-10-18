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
                OdometerUnit = req.OdometerUnit,
                AmountFilledUnit = req.AmountFilledUnit,
                CostCurrency = req.CostCurrency,
                Odometer = req.Odometer,
                AmountFilled = req.AmountFilled,
                Cost = req.Cost,
                VehicleId = req.VehicleId
            };
        }

        public static FuelLogDTO toFuelLogDTO(this UpdateFuelLogRequest req)
        {
            return new FuelLogDTO
            {
                OdometerUnit = req.UpdatedFuelLog.OdometerUnit,
                AmountFilledUnit = req.UpdatedFuelLog.AmountFilledUnit,
                CostCurrency = req.UpdatedFuelLog.CostCurrency,
                Odometer = req.UpdatedFuelLog.Odometer,
                AmountFilled = req.UpdatedFuelLog.AmountFilled,
                Cost = req.UpdatedFuelLog.Cost,
                VehicleId = req.UpdatedFuelLog.VehicleId
            };
        }
    }
}
