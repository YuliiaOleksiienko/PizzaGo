using System;
using System.Collections.Generic;

namespace PizzaGo.Models
{
    public class ConfirmedOrder
    {
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set;} 

        public DateTime CreatAt { get; set; } = DateTime.Now;
        
        public decimal TotalAmount { get; set; }

        public string Status { get; set; } = "Pending";

        public List<OrderDetail> OrderDetails { get; set; } = new();

    }
} 