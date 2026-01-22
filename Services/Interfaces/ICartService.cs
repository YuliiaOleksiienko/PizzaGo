using PizzaGo.DTOs.Responses;
using PizzaGo.Models;

namespace PizzaGo.Services.Interfaces
{
    public interface ICartService
    {
        Task AddToCartAsync(int pizzaId, int quantity);
        Task<IEnumerable<CartItemResponse>> GetCartItemsAsync();
        Task<decimal> GetTotalAmountAsync();
        Task ClearCartAsync();
        Task<CartPageResponse> GetCartPageModelAsync();
    }
}
