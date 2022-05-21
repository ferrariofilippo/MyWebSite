namespace MySite.Models
{
    public class LinkRecIng
    {
        public string RecipeId { get; set; } = null!;
        public Recipe Recipe { get; set; } = null!;
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;
        public float Quantity { get; set; }
    }
}