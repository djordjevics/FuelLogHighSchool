﻿using BusinessLogic.Models.Enums;
using BusinessLogic.Models;
using Data.Models;

namespace BusinessLogic.Mappers
{
    public static class BusinessToData
    {

        public static FuelLogData ToFuelLogData(this FuelLogDTO dto)
        {
            return new FuelLogData
            {
                Id = dto.Id,
                Odometer = dto.OdometerInKm,
                AmountFilled = dto.AmountInLiters,
                Cost = dto.CostInRsd,
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
                WheelCount = dto.WheelCount,
                FuelType = dto.FuelType.ToString()
            };
        }
    }
}
