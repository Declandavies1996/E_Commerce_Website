using System.ComponentModel.DataAnnotations;

namespace E_Commerce2.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
