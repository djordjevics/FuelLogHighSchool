using BuisinessLogic.Models.Enums;
using BusinessLogic.Models;
using Data.Models;

namespace BuisinessLogic.Mappers
{
    public class BusinessToData
    {
        private Converter converter = new Converter();

        public FuelLogData toFuellogData(FuelLogDTO fuelLogDTO)
        {
            return new FuelLogData
            {
                Id = fuelLogDTO.Id,
                Odometer = fuelLogDTO.OdometerUnit == OdometerUnit.MI ? converter.MiToKm(fuelLogDTO.Odometer) : fuelLogDTO.Odometer,
                AmountFilled = fuelLogDTO.AmountFilledUnit == AmountFilledUnit.IMPGALLONS ? converter.ImpGallonsToLiters(fuelLogDTO.AmountFilled) : fuelLogDTO.AmountFilledUnit == AmountFilledUnit.USGALLONS ? converter.UsGallonsToLiters(fuelLogDTO.AmountFilled) : fuelLogDTO.AmountFilled,
                Cost = fuelLogDTO.CostCurrency == CostCurrency.EUR ? converter.EurToRsd(fuelLogDTO.Cost) : fuelLogDTO.Cost,
                VehicleId = fuelLogDTO.VehicleId
            };
        }
    }
}
