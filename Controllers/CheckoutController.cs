using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaGo.Models;
using PizzaGo.Services.Interfaces;
using System.Security.Claims;

namespace PizzaGo.Controllers
{
    [Authorize]
    [ApiController]         
    [Route("api/[controller]")]
    
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _checkoutService;
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ICartService _cartService;

        public CheckoutController(ICheckoutService checkoutService, UserManager<ApplicationUser> userManager, ICartService cartService)
        {
            _checkoutService = checkoutService;
            _userManager = userManager;
            _cartService = cartService;
        }

    
    [HttpPost("confirm")]
    public async Task<IActionResult>ConfirmOrder()
    {
        var userId = _userManager.GetUserId(User);

        var cart = await _cartService.GetCartPageModelAsync();
        if (cart.Items.Count == 0)
        {
            return RedirectToAction("Index", "Cart");
        }

        var response = await _checkoutService.PlaceUserOrderAsync(userId);

        return View("Success", response);
    }
    }
}