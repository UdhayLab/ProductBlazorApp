using System.ComponentModel.DataAnnotations;

namespace ProductBlazorApp.Model
{
    public class EditProductModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is needed")]
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
