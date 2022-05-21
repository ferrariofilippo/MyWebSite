using System.ComponentModel.DataAnnotations;
namespace MySite.Models
{
    public class Recipe
    {
        [Key]
        public string Name { get; set; } = null!;    
        public string Description { get; set; } = null!;
        public List<LinkRecIng>? Ingredients { get; set; }
    }
}