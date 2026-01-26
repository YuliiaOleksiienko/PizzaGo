using System;
using System.Collections.Generic;

namespace PizzaGo.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string? UserId { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        
        public List<OrderDetail> OrderDetails { get; set; } = new();
        public decimal TotalPrice { get; set; }

    }
}