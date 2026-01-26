using Microsoft.AspNetCore.Identity;

namespace PizzaGo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Address { get; set; }

        public string? FullName { get; set; }
    }
}