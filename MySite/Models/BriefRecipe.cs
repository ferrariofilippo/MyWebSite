namespace MySite.Models
{
    public class BriefRecipe
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Image { get; set; }
        public BriefRecipe(Recipe r) =>
            (Name, Description, Image) =
            (r.Name, 
            r.Description.Length > 200 
                ? r.Description[..200] 
                : r.Description,
            r.Image);
    }
}
