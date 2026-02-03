using System.Net.Http.Headers;
using PizzaGo.Data;
using PizzaGo.DTOs.Responses;
using PizzaGo.Models;
using PizzaGo.Services.Interfaces;

namespace PizzaGo.Services
{
    public class CheckoutService : ICheckoutService
    {
        private  readonly AppDbContext _context;
        private readonly ICartService _cartService;

        public CheckoutService(AppDbContext context, ICartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        public async Task<OrderConfirmationResponse> PlaceUserOrderAsync(string userId)
        {
            var cartData = await _cartService.GetCartPageModelAsync();

            var finalOrder =  new ConfirmedOrder
            {
                UserId = userId,
                TotalAmount = cartData.GrandTotal,
                CreatAt = DateTime.UtcNow,
                Status = "Pending"
            };

            foreach (var item in cartData.Items)
            {
                finalOrder.OrderDetails.Add(new OrderDetail
                {
                    PizzaId = item.PizzaId,
                    Quantity = item.Quantity,
                    PriceAtPurchase = item.Price
                });
            }

            _context.ConfirmedOrders.Add(finalOrder);
            await _context.SaveChangesAsync();

            await _cartService.ClearCartAsync();

            return new OrderConfirmationResponse
            {
                OrderId = finalOrder.Id,
                TotalAmount = finalOrder.TotalAmount,
                OrderDate = finalOrder.CreatAt,
                Status = finalOrder.Status
            };

            
        }
    }
}