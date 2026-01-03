using Microsoft.EntityFrameworkCore;
using PizzaGo.Data;
using PizzaGo.Models;
using PizzaGo.Services.Interfaces;

namespace PizzaGo.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly AppDbContext _context;

        public PizzaService(AppDbContext context);
        {
            _context = context;
        }

        public async Task<IEnumerable<Pizza>> GetAllPizzasAsync()
        {
            return await _context.Pizzas.ToListAsync();
        }
    }
}