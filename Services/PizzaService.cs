using Microsoft.EntityFrameworkCore;
using PizzaGo.Data;
using PizzaGo.Models;
using PizzaGo.DTOs.Responses;
using PizzaGo.Services.Interfaces;

namespace PizzaGo.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly AppDbContext _context;

        public PizzaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PizzaResponse>> GetAllPizzasAsync()
        {
            var pizzasFromDb = await _context.Pizzas.ToListAsync();

            var response = pizzasFromDb.Select(p => new PizzaResponse
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl
            });

            return response;
        }
    }
}