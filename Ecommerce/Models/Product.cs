using System.ComponentModel;

namespace Ecommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; } //Product belongs on a category

        public ICollection<OrderItem> OrderItems { get; set; } // product can be in many order items

        public ICollection<ProductIngredient>? ProductIngredients { get; set; } // product can have many ingrediants
    }
}
