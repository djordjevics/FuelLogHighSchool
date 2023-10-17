using BusinessLogic.Interfaces;
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
            return Ok(_vehicleService.GetAllVehicles());
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicle(int vehicleId)
        {
            return Ok(_vehicleService.GetVehicleById(new ()
            {
                Id = vehicleId
            }));
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
