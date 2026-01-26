using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaGo.Models;

namespace PizzaGo.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pizza> Pizzas { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set;}


protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Pizza>().HasData(
    new Pizza { 
        Id = 1, 
        Name = "Cheesy Meat", 
        Price = 13.99m, 
        Description = "A hearty pizza loaded with ground beef and extra melted mozzarella on a thick crust.", 
        ImageUrl = "/images/pizzas/foad-roshan-nDlXtnzsD5o-unsplash.jpg" 
    },
    new Pizza { 
        Id = 2, 
        Name = "Tropical Feast", 
        Price = 12.50m, 
        Description = "Sweet pineapple chunks, savory ham, and crispy bacon bits over a rich tomato base.", 
        ImageUrl = "/images/pizzas/heather-barnes-YKvGUO4Zb7Y-unsplash.jpg" 
    },
    new Pizza { 
        Id = 3, 
        Name = "Chicken & Pepper", 
        Price = 14.00m, 
        Description = "Juicy grilled chicken pieces mixed with fresh green bell peppers and aromatic herbs.", 
        ImageUrl = "/images/pizzas/rizwan-ahmed-E38gYohvCGs-unsplash.jpg" 
    },
    new Pizza { 
        Id = 4, 
        Name = "Classic Pepperoni", 
        Price = 11.99m, 
        Description = "Traditional thin-crust pizza topped with generous layers of spicy pepperoni and cheese.", 
        ImageUrl = "/images/pizzas/pexels-polina-tankilevitch-4109085.jpg" 
    },
    new Pizza { 
        Id = 5, 
        Name = "Spicy Salami", 
        Price = 13.50m, 
        Description = "For those who like it hot: premium spicy salami with double cheese and a smokey finish.", 
        ImageUrl = "/images/pizzas/foad-roshan-JOYjHvOTFJQ-unsplash.jpg" 
    },
    new Pizza { 
        Id = 6, 
        Name = "Hunter's Pizza", 
        Price = 12.00m, 
        Description = "A rustic mix of savory salami, fresh mushrooms, and black olives.",
        ImageUrl = "/images/pizzas/pexels-roman-odintsov-5903178.jpg" 
    },
    new Pizza { 
        Id = 7, 
        Name = "Beef & Mushroom", 
        Price = 14.50m, 
        Description = "Savory beef slices paired with forest mushrooms and creamy mozzarella cheese.", 
        ImageUrl = "/images/pizzas/foad-roshan-QRUFgHHd2F8-unsplash.jpg" 
    },
    new Pizza { 
        Id = 8, 
        Name = "Pepperoni Basil", 
        Price = 13.00m, 
        Description = "Fresh basil leaves and crispy pepperoni slices on a zesty tomato and garlic sauce.", 
        ImageUrl = "/images/pizzas/mike-cox-dlctifSsn_8-unsplash.jpg" 
    }
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