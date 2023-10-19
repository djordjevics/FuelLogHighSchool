using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Implementations;
using BusinessLogic.Models;
using BusinessLogic.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelLogController : Controller
    {
        private IFuelLogService _fuelLogService = new FuelLogService();

        [HttpPost]
        public IActionResult AddLog(CreateFuelLog createFuelLog)
        {
            _fuelLogService.AddFuelLogToVehicle(createFuelLog);
            return Ok();
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            _fuelLogService.GetAllFuelLogs();
            return Ok();
        }
        
        [HttpGet("vehicle/{vehicleId}")]
        public IActionResult GetByVehicle(int vehicleId, string amountUnit, string odometerUnit, string costCurrency)
        {
            return Ok(_fuelLogService.GetAllFuelLogsByVehicleId(new()
            {
                VehicleId = vehicleId,
                AmountFilledUnit = Enum.Parse<AmountFilledUnit>(amountUnit),
                OdometerUnit = Enum.Parse<OdometerUnit>(odometerUnit),
                CostCurrency = Enum.Parse<CostCurrency>(costCurrency)
            }));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id, string amountUnit, string odometerUnit, string costCurrency)
        {
            return Ok(_fuelLogService.GetFuelLogById(new()
            {
                Id = id,
                AmountFilledUnit = Enum.Parse<AmountFilledUnit>(amountUnit),
                OdometerUnit = Enum.Parse<OdometerUnit>(odometerUnit),
                CostCurrency = Enum.Parse<CostCurrency>(costCurrency)
            }));
        }
        
        [HttpPut]
        public IActionResult UpdateLog(UpdateFuelLogRequest updateFuelLogRequest)
        {
            _fuelLogService.UpdateFuelLog(updateFuelLogRequest);
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult DeleteLog(int fuelLogId)
        {
            _fuelLogService.DeleteFuelLog(new()
            {
                Id = fuelLogId
            });
            return Ok();
        }
    }
}
