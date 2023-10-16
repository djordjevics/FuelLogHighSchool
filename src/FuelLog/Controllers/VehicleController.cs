using Microsoft.AspNetCore.Mvc;

namespace BuisinessLogic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        [HttpPost]
        public IActionResult AddVehicle()
        {
            throw new NotImplementedException();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVehicle()
        {
            throw new NotImplementedException();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicle()
        {
            throw new NotImplementedException();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteVehicle()
        {
            throw new NotImplementedException();
            return Ok();
        }
    }
}
