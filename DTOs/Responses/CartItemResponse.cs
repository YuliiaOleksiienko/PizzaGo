namespace PizzaGo.DTOs.Responses
{
    public class CartItemResponse
    {
        public PizzaResponse Pizza { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal TotalPrice => Pizza.Price * Quantity;
    }
}