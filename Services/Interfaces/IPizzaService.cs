using PizzaGo.Models;

namespace PizzaGo.Services.Interfaces 
{
    public interface IPizzaService
    {
        Task<IEnumerable<Pizza>> GetAllPizzasAsync();
    }
}