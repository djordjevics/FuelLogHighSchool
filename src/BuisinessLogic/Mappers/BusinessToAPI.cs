using BusinessLogic.Models;
using FuelLogAPI.Models;
using FuelLogAPI.Models.Enums;

namespace BusinessLogic.Mappers
{
    public class BusinessToAPI
    {
        public Vehicle toVehicle(VehicleDTO vehicleDTO)
        {
            return new Vehicle
            {
                Id = vehicleDTO.Id,
                Model = vehicleDTO.Model,
                Color = vehicleDTO.Color,
                LicensePlate = vehicleDTO.LicensePlate,
                FuelType = (FuelType)vehicleDTO.FuelType,
                WheelCount = vehicleDTO.WheelCount
            };
        }

        public FuelLog toFuelLog(FuelLogDTO fuelLogDTO)
        {
            return new FuelLog
            {
                Id = fuelLogDTO.Id,
                AmountFilled = fuelLogDTO.AmountFilled,
                AmountFilledUnit = (AmountFilledUnit)fuelLogDTO.AmountFilledUnit,
                Odometer = fuelLogDTO.Odometer,
                OdometerUnit = (OdometerUnit)fuelLogDTO.OdometerUnit,
                Cost = fuelLogDTO.Cost,
                CostCurrency = (CostCurrency)fuelLogDTO.CostCurrency,
                VehicleId = fuelLogDTO.VehicleId
            };
        }
    }
}
