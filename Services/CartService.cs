using Microsoft.AspNetCore.Http;
using PizzaGo.DTOs.Responses;
using PizzaGo.Services.Interfaces;
using System.Text.Json;

namespace PizzaGo.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPizzaService _pizzaService;
        private const string CartSessionKey = "PizzaCart";

        public CartService(IHttpContextAccessor httpContextAccessor, IPizzaService pizzaService)
        {
            _httpContextAccessor = httpContextAccessor;
            _pizzaService = pizzaService;
        }

        public async Task AddToCartAsync(int pizzaId, int quantity)
        {
            var cart = (await GetCartItemsAsync()).ToList();
            var existingItem = cart.FirstOrDefault(x => x.Pizza.Id == pizzaId);

            if(existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                var allPizzas = await _pizzaService.GetAllPizzasAsync();
                var pizza = allPizzas.FirstOrDefault(p => p.Id == pizzaId);
                if (pizza != null)
                {
                    cart.Add(new CartItemResponse
                    { 
                    Pizza = pizza,
                    Quantity = quantity
                    });
                }
            }
            SaveCartToSession(cart);
        }

        public Task<IEnumerable<CartItemResponse>> GetCartItemsAsync()
        {
            var session = _httpContextAccessor.HttpContext?.Session;
            var cartJson = session?.GetString(CartSessionKey);
            
            if (string.IsNullOrEmpty(cartJson))
            {
                return Task.FromResult<IEnumerable<CartItemResponse>>(new List<CartItemResponse>());
            }
            var result = JsonSerializer.Deserialize<List<CartItemResponse>>(cartJson)!;
            return Task.FromResult<IEnumerable<CartItemResponse>>(result);
        }

        public async Task<decimal> GetTotalAmountAsync()
        {
            var cart = await GetCartItemsAsync();
            return cart.Sum(x => x.TotalPrice);
        }

        public Task ClearCartAsync()
        {
            _httpContextAccessor.HttpContext?.Session.Remove(CartSessionKey);
            return Task.CompletedTask;
        }

        private void SaveCartToSession(List<CartItemResponse> cart)
        {
            var json = JsonSerializer.Serialize(cart);
            _httpContextAccessor.HttpContext?.Session.SetString(CartSessionKey, json);
        }
    }
}
