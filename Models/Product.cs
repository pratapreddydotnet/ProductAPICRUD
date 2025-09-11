using System.ComponentModel.DataAnnotations;

namespace ProductAPICRUD.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
