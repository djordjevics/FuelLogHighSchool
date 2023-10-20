using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Implementations;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessLogic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        private IVehicleService _vehicleService = new VehicleService();

        [HttpPost]
        public IActionResult AddVehicle(CreateVehicle createVehicle)
        {
            _vehicleService.AddVehicle(createVehicle);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var vehicles = _vehicleService.GetAllVehicles();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicle(int vehicleId)
        {
            return Ok(_vehicleService.GetVehicleById(new ()
            {
                Id = vehicleId
            }));
        }

        [HttpGet("fuelConsumption/{id}")]
        public IActionResult GetAvgFuelConsumption(int vehicleId)
        {
            return Ok(_vehicleService.AvgFuelConsumption(vehicleId));
        }

        [HttpGet("fuelConsumption")]
        public IActionResult GetAvgFuelConsumptionBetweenFuelLogs(int vehicleId, int fuelLog1Id, int fuelLog2Id)
        {
            return Ok(_vehicleService.AvgFuelConsumptionBetweenFuelLogs(vehicleId, fuelLog1Id, fuelLog2Id));
        }

        [HttpPut]
        public IActionResult UpdateVehicle(UpdateVehicleRequest updateVehicleRequest)
        {
            _vehicleService.UpdateVehicle(updateVehicleRequest);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteVehicle(int vehicleId)
        {
            _vehicleService.DeleteVehicle(new()
            {
                Id = vehicleId
            });
            return Ok();
        }
    }
}
