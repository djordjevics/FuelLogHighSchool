using Microsoft.AspNetCore.Mvc;

namespace FuelLog.Controllers
{
    public class FuelLogController : Controller
    {
       public IActionResult AddLog()
       {
            if (GetById(Id) != FuelLog)
            {
                return BadRequest();
            }

            AddLog(FuelLog);
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

        public IActionResult GetByVehicle()
        {
            if (GetByVehicle == null)
            {
                return NotFound();
            }
            return Ok(GetByVehicle());
        }

        public IActionResult GetById()
        {
            if (GetById(Id) == null)
            {
                return NotFound();
            }
            return Ok(GetById());
        }

        public IActionResult UpdateLog()
        {
            if (GetType(GetById(Id)) != FuelLog)
            {
                return BadRequest();
            }

            UpdateLog(FuelLog);

            return Ok();
        }

        public IActionResult DeleteLog()
        {
            if (GetById(Id) == null)
            {
                return NotFound();
            }

            DeleteLog(id);

            return Ok();
        }
    }
}
