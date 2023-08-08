using Microsoft.AspNetCore.Identity;

namespace E_Commerce2.Models
{
    public class ShoppingCart
    {
        public IdentityUser User { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
