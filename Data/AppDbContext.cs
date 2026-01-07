using Microsoft.EntityFrameworkCore;
using PizzaGo.Models;

namespace PizzaGo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pizza> Pizzas { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set;}


protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Pizza>().HasData(
        new Pizza { Id = 1, Name = "Margarita", Price = 10.99m, Description = "Traditional Italian pizza with tomato sauce, fresh mozzarella and basil.", ImageUrl = "" },
        new Pizza { Id = 2, Name = "Pepperoni", Price = 12.99m, Description = "Classic American favorite with spicy pepperoni slices and extra mozarella.", ImageUrl = "" },
        new Pizza { Id = 3, Name = "Four Cheese", Price = 13.50m, Description = "A rich blend of Parmesan, Gorgonzola, Cheddar, and Mozarella.", ImageUrl = "" },
        new Pizza { Id = 4, Name = "Hawaiian", Price = 11.50m, Description = "The controversial classic with juicy pineapple, ham, and tomato sauce.", ImageUrl = "" },
        new Pizza { Id = 5, Name = "BBQ Chicken", Price = 14.00m, Description = "Grilled chicken, red onions, and smoky BBQ sauce instead of tomato base.", ImageUrl = "" },
        new Pizza { Id = 6, Name = "Vegetarian", Price = 11.00m, Description = "Loaded with fresh bell peppers, mushrooms, olives, and red onions.", ImageUrl = "" }
    );


    modelBuilder.Entity<OrderDetail>()
        .HasOne(od => od.Order)
        .WithMany(o => o.OrderDetails)
        .HasForeignKey(od => od.OrderId);


    modelBuilder.Entity<OrderDetail>()
        .HasOne(od => od.Pizza)
        .WithMany()
        .HasForeignKey(od => od.PizzaId);

}

}