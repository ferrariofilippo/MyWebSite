namespace MySite.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Resume { get; set; } = "";
        public List<LinkRecIng>? Ingredients { get; set; }
        public byte[] Image { get; set; }
    }
}