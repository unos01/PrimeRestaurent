using Microsoft.AspNetCore.Identity;

namespace PrimeRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
