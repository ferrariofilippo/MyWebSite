namespace MySite.Models
{
    public class BriefRecipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Image { get; set; }
        public BriefRecipe(Recipe r) =>
            (RecipeId, Name, Description, Image) =
            (r.RecipeId,
            r.Name, 
            r.Resume,
            r.Image);
    }
}
