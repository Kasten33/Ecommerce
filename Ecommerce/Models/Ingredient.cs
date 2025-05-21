namespace Ecommerce.Models
{
    public class Ingredient
    {
        public int IngrediantId { get; set; }

        public string Name { get; set; }

        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}