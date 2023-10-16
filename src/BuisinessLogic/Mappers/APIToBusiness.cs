using BusinessLogic.Models.Enums;
using BusinessLogic.Models;

namespace BusinessLogic.Mappers
{
    public static class APIToBusiness
    {
        public static VehicleDTO toVehicleDTO(this CreateVehicle create)
        {
            return new VehicleDTO
            {
                Color = create.Color,
                Model = create.Model,
                LicensePlate = create.LicensePlate,
                WheelCount = create.WheelCount,
                FuelType = create.FuelType
            };
        }

        public static VehicleDTO toVehicleDTO(this UpdateVehicleRequest req)
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

        public static FuelLogDTO toFuelLogDTO(this CreateFuelLog create)
        {
            return new FuelLogDTO
            {
                Odometer = create.Odometer,
                OdometerUnit = create.OdometerUnit,
                AmountFilled = create.AmountFilled,
                AmountFilledUnit = create.AmountFilledUnit,
                Cost = create.Cost,
                CostCurrency = create.CostCurrency,
                VehicleId = create.VehicleId
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
