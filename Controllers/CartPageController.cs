using Microsoft.AspNetCore.Mvc;
using PizzaGo.Services.Interfaces;
using PizzaGo.DTOs.Responses;

namespace PizzaGo.Controllers
{
        public class CartPageController : Controller
        {
            private readonly ICartService _cartService;
            public CartPageController(ICartService cartService)
            {
                _cartService = cartService;
            }

            [HttpGet("/Cart")]
            public async Task<IActionResult> Index()
            {
                var response = await _cartService.GetCartPageModelAsync();
                return View(response);


            }
        }
}