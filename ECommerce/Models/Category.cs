using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Category
    {

        // // This constructor initializes the Products collection 
        // to make sure it's not null when a new Category object is created.
        // Using HashSet prevents duplicate products in the same category.
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } /*= new HashSet<Product>() => we can create Hash set of Product after the Navigational Property*/

    }
}
