using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce2.Models
{
    public class Inventory
    {
        [Required]
        public int InventoryId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int TotalInventory { get; set; }
    }
}
