using System.ComponentModel.DataAnnotations;

namespace ProductBlazorApp.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string? Name { get; set; }

        [Required] 
        public string? Description { get; set; }
        
        [Required]
        public string? BrandName { get; set; }

        [Required] 
        public int CategoryId { get; set; }
        [Required]
        public double Price { get; set; }
    }
}