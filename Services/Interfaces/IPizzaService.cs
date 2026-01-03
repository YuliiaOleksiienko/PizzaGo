using PizzaGo.Models;

namespace PizzaGo.Services.interfaces 
{
    public interface IPizzaService
    {
        Task<IEnumerable<Pizza>> GetAllPizzasAsync();
    }
}