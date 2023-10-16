using BusinessLogic.Models.Enums;
using BusinessLogic.Models;
using FuelLogAPI.Models;

namespace BusinessLogic.Mappers
{
    public class APIToBusiness
    {
        public VehicleDTO toVehicleDTO(CreateVehicle createVehicle)
        {
            return new VehicleDTO
            {
                Color = createVehicle.Color,
                Model = createVehicle.Model,
                LicensePlate = createVehicle.LicensePlate,
                WheelCount = createVehicle.WheelCount,
                FuelType = (FuelType)createVehicle.FuelType
            };
        }

        public VehicleDTO toVehicleDTO(UpdateVehicleRequest updateVehicleRequest)
        {
            return new VehicleDTO
            {
                Color = updateVehicleRequest.UpdatedVehicle.Color,
                Model = updateVehicleRequest.UpdatedVehicle.Model,
                LicensePlate = updateVehicleRequest.UpdatedVehicle.LicensePlate,
                WheelCount = updateVehicleRequest.UpdatedVehicle.WheelCount,
                FuelType = (FuelType)updateVehicleRequest.UpdatedVehicle.FuelType
            };
        }

        public FuelLogDTO toFuelLogDTO(CreateFuelLog createFuelLog)
        {
            return new FuelLogDTO
            {
                Odometer = createFuelLog.Odometer,
                OdometerUnit = (OdometerUnit)createFuelLog.OdometerUnit,
                AmountFilled = createFuelLog.AmountFilled,
                AmountFilledUnit = (AmountFilledUnit)createFuelLog.AmountFilledUnit,
                Cost = createFuelLog.Cost,
                CostCurrency = (CostCurrency)createFuelLog.CostCurrency,
                VehicleId = createFuelLog.VehicleId
            };
        }

        public FuelLogDTO toFuelLogDTO(UpdateFuelLogRequest updateFuelLogRequest)
        {
            return new FuelLogDTO
            {
                Odometer = updateFuelLogRequest.UpdatedFuelLog.Odometer,
                OdometerUnit = (OdometerUnit)updateFuelLogRequest.UpdatedFuelLog.OdometerUnit,
                AmountFilled = updateFuelLogRequest.UpdatedFuelLog.AmountFilled,
                AmountFilledUnit = (AmountFilledUnit)updateFuelLogRequest.UpdatedFuelLog.AmountFilledUnit,
                Cost = updateFuelLogRequest.UpdatedFuelLog.Cost,
                CostCurrency = (CostCurrency)updateFuelLogRequest.UpdatedFuelLog.CostCurrency,
                VehicleId = updateFuelLogRequest.UpdatedFuelLog.VehicleId
            };
        }
    }
}
