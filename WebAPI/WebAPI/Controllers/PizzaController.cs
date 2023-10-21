using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }

        [HttpGet("{id}/{size}")]
        public ActionResult<List<Pizza>> GetByIdAndSize(int id, string size)
        {
            List<Pizza> PizzaList = PizzaService.GetByIdAndSize(id, size);

            if (PizzaList.Count == 0)
                return NotFound();

            return PizzaList;
        }
    }
}
