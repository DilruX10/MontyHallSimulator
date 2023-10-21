using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MontyHallController : ControllerBase
    {
        public MontyHallController()
        {
        }

        [HttpGet("{size}/{changed}")]
        public ActionResult<List<MontyHall>> GetSims(int size, string changed)
        {
            Boolean changedBool = (changed.ToLower() == "true")? true : false;

            List<MontyHall> MontyHallList = MontyHallService.GetSims(size, changedBool);

            if (MontyHallList.Count == 0)
                return NotFound();

            return MontyHallList;
        }
    }
}
