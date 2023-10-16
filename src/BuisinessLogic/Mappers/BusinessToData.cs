using BuisinessLogic.Models.Enums;
using BusinessLogic.Models;
using Data.Models;

namespace BuisinessLogic.Mappers
{
    public class BusinessToData
    {
        public FuelLogData toFuellogData(FuelLogDTO fuelLogDTO)
        {
            return new FuelLogData
            {
                Id = fuelLogDTO.Id,
                Odometer = fuelLogDTO.OdometerUnit == OdometerUnit.MI ? Converter.MiToKm(fuelLogDTO.OdometerUnit) : fuelLogDTO.OdometerUnit,
                AmountFilled = fuelLogDTO.AmountFilledUnit == AmountFilledUnit.IMPGALLONS ? Converter.
            };
        }
    }
}
