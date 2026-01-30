namespace PizzaGo.DTOs.Responses
{
    public class OrderConfirmationResponse
    {
        public int OrderId { get; set;}
        public decimal TotalAmount { get; set;} 

        public DateTime OrderDate { get; set;}

        public string Status { get; set;} = "Pending";
    }
}