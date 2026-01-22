namespace PizzaGo.DTOs.Responses
{
    public class CartPageResponse
    {
        public List<CartItemDTO> Items { get; set; } = new();
        public decimal GrandTotal { get; set; }
    }

    public class CartItemDTO
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal => Price * Quantity; 

    }
}
