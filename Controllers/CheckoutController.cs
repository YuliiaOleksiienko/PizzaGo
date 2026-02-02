using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaGo.Services.Interfaces;
using System.Security.Claims;

namespace PizzaGo.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly ICheckoutService _checkoutService;
        private readonly UserManager<IdentityUser> _userManager;

        public CheckoutController(ICheckoutService checkoutService, UserManager<IdentityUser> userManager)
        {
            _checkoutService = checkoutService;
            _userManager = userManager;
        }

    
    [HttpPost]
    public async Task<IActionResult>ConfirmOrder()
    {
        var userId = _userManager.GetUserId(User);

        if (string.IsNullOrEmpty(userId))
        {
            return RedirectToAction("Login", "Account");
        }

        var response = await _checkoutService.PlaceUserOrderAsync(userId);

        return View("Success", response);
    }
    }
}