using ECommerce.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public ProductColor ProductColor { get; set; }

        // Navigational Property 
        public int CategoryId { get; set; } // Foreign Key
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
