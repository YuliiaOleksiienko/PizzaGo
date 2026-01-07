using System;
using System.Collections.Generic;

namespace PizzaGo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string? UserId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; } = new();
        public decimal TotalPrice { get; set; }

    }
}