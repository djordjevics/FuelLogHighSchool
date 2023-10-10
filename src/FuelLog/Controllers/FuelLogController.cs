using Microsoft.AspNetCore.Mvc;

namespace FuelLog.Controllers
{
    [ApiController]
    public class FuelLogController : Controller
    {
    
        [HttpPost]
        public IActionResult AddLog()
        {
           throw new NotDefinedException();
           return Ok();
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotDefinedException();
            return Ok();
        }
        
        [HttpGet]
        public IActionResult GetByVehicle()
        {
            throw new NotDefinedException();
            return Ok();
        }
        
        [HttpGet]
        public IActionResult GetById()
        {
            throw new NotDefinedException();
            return Ok();
        }
        
        [HttpPut]
        public IActionResult UpdateLog()
        {
            throw new NotDefinedException();
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult DeleteLog()
        {
            throw new NotDefinedException();
            return Ok();
        }
    }
}
