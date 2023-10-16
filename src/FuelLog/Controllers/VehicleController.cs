using BuisinessLogic.Intefaces;
using FuelLogAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuisinessLogic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        private IVehicleService _vehicleService = new VehicleService();

        [HttpPost]
        public IActionResult AddVehicle()
        {
            _vehicleService.AddVehicle(CreateVehicle createVehicle);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return _vehicleService.GetAllVehicles();
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicle()
        {
            return _vehicleService.GetVehicleById(GetVehicleById getVehicleById);
        }

        [HttpPut]
        public IActionResult UpdateVehicle()
        {
            _vehicleService.UpdateVehicle(UpdateVehicleRequest updateVehicleRequest);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteVehicle()
        {
            _vehicleService.DeleteVehicle(DeleteVehicleRequest deleteVehicleRequest);
            return Ok();
        }
    }
}
