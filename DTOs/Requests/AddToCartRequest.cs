namespace PizzaGo.DTOs.Requests
{
    public class AddToCartRequest
    {
        public int PizzaId { get; set; }
        public int Quantity { get; set;}

        public AddToCartRequest(){}

        public AddToCartRequest(int pizzaId, int quantity)
        {
            PizzaId = pizzaId;
            Quantity = quantity;
        }
    }
}