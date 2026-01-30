using PizzaGo.DTOs.Responses;

namespace PizzaGo.Services.Interfaces
{
    public interface ICheckoutService
    {
        Task<OrderConfirmationResponse> PlaceUserOrderAsync(string userId);
    }
}