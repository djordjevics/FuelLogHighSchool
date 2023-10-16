using BuisinessLogic.Intefaces;
using FuelLogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelLogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelLogController : Controller
    {
        private IFuelLogService _fuelLogService = new FuelLogService();

        [HttpPost]
        public IActionResult AddLog()
        {
            _fuelLogService.AddFuelLogToVehicle(CreateFuelLog createFuelLog);
            return Ok();
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            _fuelLogService.GetAllFuelLogs();
            return Ok();
        }
        
        [HttpGet("vehicle/{vehicleId}")]
        public IActionResult GetByVehicle()
        {
            return _fuelLogService.GetAllFuelLogsByVehicleId(GetFuelLogsByVehicleId getFuelLogsByVehicleId);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            return _fuelLogService.GetFuelLogById(GetFuelLogById getFuelLogById);
        }
        
        [HttpPut]
        public IActionResult UpdateLog()
        {
            _fuelLogService.UpdateFuelLog(UpdateFuelLogRequest updateFuelLogRequest);
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult DeleteLog()
        {
            _fuelLogService.DeleteFuelLog(DeleteFuelLogRequest deleteFuelLogRequest);
            return Ok();
        }
    }
}
