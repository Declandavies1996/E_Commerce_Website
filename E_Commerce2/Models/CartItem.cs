using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce2.Models
{
    public class CartItem
    {
        [Required]
        public int CartItemId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
