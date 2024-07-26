using System.ComponentModel.DataAnnotations;

namespace Pruebalinktic.Shared.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        public Product? Product { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "Imagen")]
        public string Image { get; set; } = null!;
    }
}