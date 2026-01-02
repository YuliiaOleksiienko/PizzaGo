using Microsoft.EntityFrameworkCore;
using PizzaGo.Models;

namespace PizzaGo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pizza> Pizzas { get; set; }
}