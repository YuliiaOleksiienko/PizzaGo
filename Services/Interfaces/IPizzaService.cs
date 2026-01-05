using PizzaGo.DTOs.Responses;

namespace PizzaGo.Services.Interfaces 
{
    public interface IPizzaService
    {
        Task<IEnumerable<PizzaResponse>> GetAllPizzasAsync();
    }
}