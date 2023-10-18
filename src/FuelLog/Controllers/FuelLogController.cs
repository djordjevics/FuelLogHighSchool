using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Implementations;
using BusinessLogic.Models;
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
        public IActionResult GetByVehicle(int vehicleId)
        {
            return Ok(_fuelLogService.GetAllFuelLogsByVehicleId(new()
            { 
                VehicleId = vehicleId 
            }));
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int fuelLogId)
        {
            return Ok(_fuelLogService.GetFuelLogById(new()
            {
                Id = fuelLogId
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
