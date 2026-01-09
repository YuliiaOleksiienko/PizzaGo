using Microsoft.AspNetCore.Mvc;
using PizzaGo.DTOs.Responses;
using PizzaGo.Services.Interfaces;


namespace PizzaGo.Controllers
{
   
    public class PizzasController : Controller
    {
        private readonly IPizzaService _pizzaService;

        public PizzasController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pizzas = await _pizzaService.GetAllPizzasAsync();
            return View(pizzas);
        }
    }
    
}
