namespace PizzaGo.Models;

public class OrderDetail
{
    public int id { get; set; }
    public int? OrderId { get; set; }
    public Order? Order { get; set; } = null!;

    public int? ConfirmedOrderId { get; set; }
    public ConfirmedOrder? ConfirmedOrder { get; set; }

    public int PizzaId { get; set; }
    public Pizza Pizza { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal PriceAtPurchase { get; set; }

} 