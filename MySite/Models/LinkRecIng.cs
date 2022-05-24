namespace MySite.Models
{
    public class LinkRecIng
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;
        public float Quantity { get; set; }
    }
}