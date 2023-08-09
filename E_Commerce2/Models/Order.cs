using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce2.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey("User")]
        public string Username { get; set; }
        public IdentityUser User { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public OrderStatus Status { get; set; }

        //Navigation Properties
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
