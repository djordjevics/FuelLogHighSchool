using Microsoft.AspNetCore.Mvc;

namespace FuelLog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuelLogController : Controller
    {
    
        [HttpPost]
        public IActionResult AddLog()
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
        
        [HttpGet("vehicle/{vehicleId}")]
        public IActionResult GetByVehicle()
        {
            throw new NotImplementedException();
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById()
        {
            throw new NotImplementedException();
            return Ok();
        }
        
        [HttpPut]
        public IActionResult UpdateLog()
        {
            throw new NotImplementedException();
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult DeleteLog()
        {
            throw new NotImplementedException();
            return Ok();
        }
    }
}
