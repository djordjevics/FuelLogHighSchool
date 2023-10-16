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
                Odometer = dto.OdometerUnit == OdometerUnit.MI ? dto.Odometer.MiToKm() : dto.Odometer,
                AmountFilled = dto.AmountFilledUnit == AmountFilledUnit.IMPGALLONS ? dto.AmountFilled.ImpGallonsToLiters() : dto.AmountFilledUnit == AmountFilledUnit.USGALLONS ? dto.AmountFilled.UsGallonsToLiters() : dto.AmountFilled,
                Cost = dto.CostCurrency == CostCurrency.EUR ? dto.Cost.EurToRsd() : dto.Cost,
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
