namespace MySite.Models
{
    public class BriefRecipe
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public BriefRecipe(Recipe r) =>
            (Name, Description) =
            (r.Name, 
            r.Description.Length > 200 
                ? r.Description[..200] 
                : r.Description);
    }
}
