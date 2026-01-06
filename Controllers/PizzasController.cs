using Microsoft.AspNetCore.Mvc;
using PizzaGo.DTOs.Responses;
using PizzaGo.Services.Interfaces;


namespace PizzaGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class PizzasController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;

        public PizzasController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaResponse>>> GetAll()
        {
            var pizzas = await _pizzaService.GetAllPizzasAsync();
            return Ok(pizzas);
        }
    }
    
}
