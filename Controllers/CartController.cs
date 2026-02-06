using Microsoft.AspNetCore.Mvc;
using PizzaGo.Services.Interfaces;
using PizzaGo.DTOs.Requests;
using System.Linq;

namespace PizzaGo.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromForm] AddToCartRequest request)
        {
            if (request.Quantity <= 0)
            {
                return BadRequest("Quantity must be more than 0");
            }

            await _cartService.AddToCartAsync(request.PizzaId, request.Quantity);
            
            var items = await _cartService.GetCartItemsAsync();
            var totalCount = items.Sum(x => x.Quantity);
            return Ok(totalCount);
        }   

        [HttpPost("UpdateQuantity")]
        public async Task<IActionResult> UpdateQuantity([FromForm] int id, [FromForm] int change)
        {
            await _cartService.UpdateQuantityAsync(id, change);

            return RedirectToAction("Index", "CartPage");
        }

    }
}