using PizzaGo.Models;

namespace PizzaGo.Services.Interfaces
{
    public interface ICartService
    {
        Task AddToCartAsync(int pizzaId, int quantity);
        Task<IEnumerable<OrderDetail>> GetCartItemsAsync();
        Task<decimal> GetTotalAmountAsync();
        Task ClearCartAsync();
    }
}