using Microsoft.AspNetCore.Mvc;

namespace FuelLog.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult AddVehicle()
        {
            if (GetType(GetVehicle(Id)) != Vehicle)
            {
                return BadRequest();
            }

            AddVehicle(Vehicle);
            return Ok();
        }

        public IActionResult GetAll()
        {
            if (GetAll == null)
            {
                return NotFound();
            }
            return Ok(GetAll());
        }

        public IActionResult GetVehicle()
        {
            if (GetVehicle == null)
            {
                return NotFound();
            }
            return Ok(GetVehicle());
        }

        public IActionResult UpdateVehicle()
        {
            if (GetVehicle(Id) != Vehicle)
            {
                return BadRequest();
            }
            UpdateVehicle(Vehicle);

            return Ok();
        }

        public IActionResult DeleteVehicle()
        {
            if (GetVehicle == null)
            {
                return NotFound();
            }

            DeleteVehicle(Vehicle);

            return Ok();
        }
        
        return View();
    }
}
